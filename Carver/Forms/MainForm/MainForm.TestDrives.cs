using Carver.Forms;
using Carver.Forms.Prospect;
using Carver.Models;

namespace Carver
{
    internal partial class MainForm
    {
        private void LoadScheduledTestDrives()
        {
            var testDrives = chkShowCancelled.Checked
            ? _testDriveService.GetByStatuses(TestDriveStatus.Scheduled, TestDriveStatus.Cancelled)
            : _testDriveService.GetByStatus(TestDriveStatus.Scheduled);

            dgvScheduled.DataSource = testDrives.OrderBy(t => t.ScheduledAt).ToList();
        }

        private void LoadCompletedTestDrives()
        {
            dgvCompleted.DataSource = _testDriveService.GetByStatus(TestDriveStatus.Completed);
        }

        private void ResetTestDriveForm()
        {
            _editingTestDrive = null;
            _selectedProspect = null;

            rtbInterestReason.Clear();
            dtpTestDriveDateTime.Value = DateTime.Now;
            txtSearchProspect.Clear();
            btnTestDriveSubmit.Text = "Proefrit inplannen";

            lblFirstName.Text = "-";
            lblLastName.Text = "-";
            lblEmail.Text = "-";
            lblPhone.Text = "-";
            lblAddress.Text = "-";
            lblCity.Text = "-";
            chkHasDrivingLicense.Checked = false;
            chkHasScooterLicense.Checked = false;
            chkIsDisabledVehicle.Checked = false;
        }

        private void txtSearchProspect_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearchProspect.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                lstProspects.Visible = false;
                return;
            }

            var filtered = _prospectService.Search(query);
            lstProspects.DataSource = filtered;
            lstProspects.DisplayMember = "FullName";
            lstProspects.Visible = true;
        }

        private void lstProspects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prospect? selected = lstProspects.SelectedItem as Prospect;
            if (selected == null) return;

            DisplaySelectedProspect(selected);
            lstProspects.Visible = false;
        }

        private void btnTestDriveNewProspect_Click(object sender, EventArgs e)
        {
            NewProspectForm form = new NewProspectForm();
            if (form.ShowDialog() == DialogResult.OK && form.CreatedProspect != null)
            {
                _allProspects = _prospectService.GetAll();
                DisplaySelectedProspect(form.CreatedProspect);
            }
        }

        private void btnTestDriveSubmit_Click(object sender, EventArgs e)
        {
            if (_selectedProspect == null)
            {
                MessageBox.Show("Selecteer eerst een prospect.", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CarverModelType modelType = (CarverModelType)cmbInterestedModel.SelectedIndex;
                Models.Carver carver = new Models.Carver(modelType);

                if (_editingTestDrive != null)
                {
                    _editingTestDrive.Prospect = _selectedProspect;
                    _editingTestDrive.Carver = carver;
                    _editingTestDrive.ScheduledAt = dtpTestDriveDateTime.Value;
                    _editingTestDrive.Reason = rtbInterestReason.Text.Trim();

                    _testDriveService.Update(_editingTestDrive);

                    MessageBox.Show("Proefrit bijgewerkt.", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TestDrive testDrive = new TestDrive(
                        _selectedProspect,
                        carver,
                        dtpTestDriveDateTime.Value,
                        rtbInterestReason.Text.Trim()
                    );

                    _testDriveService.Add(testDrive);

                    MessageBox.Show("Proefrit ingepland.", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetTestDriveForm();
                LoadScheduledTestDrives();
                LoadCompletedTestDrives();
                LoadDashboard();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvScheduled_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colStatus.Index) return;

            TestDrive? testDrive = dgvScheduled.Rows[e.RowIndex].DataBoundItem as TestDrive;
            if (testDrive == null) return;

            if (dgvScheduled.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is TestDriveStatus newStatus)
            {
                _testDriveService.UpdateStatus(testDrive.Id, newStatus);
                LoadDashboard();
                LoadScheduledTestDrives();
                LoadCompletedTestDrives();
            }
        }

        private void dgvScheduled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colScheduledEdit.Index) return;

            TestDrive? selected = dgvScheduled.Rows[e.RowIndex].DataBoundItem as TestDrive;
            if (selected == null) return;

            tabMain.SelectedTab = tpNewTestDrive;

            _editingTestDrive = selected;
            DisplaySelectedProspect(selected.Prospect);
            dtpTestDriveDateTime.Value = selected.ScheduledAt;
            cmbInterestedModel.SelectedIndex = (int)selected.Carver.ModelType;
            rtbInterestReason.Text = selected.Reason;
            btnTestDriveSubmit.Text = "Proefrit bijwerken";
        }

        private void dgvCompleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colExperience.Index) return;

            TestDrive? selected = dgvCompleted.Rows[e.RowIndex].DataBoundItem as TestDrive;
            if (selected == null) return;

            Experience? existing = _experienceService.GetByTestDriveId(selected.Id);
            ExperienceForm form = existing != null
                ? new ExperienceForm(selected.Id, existing)
                : new ExperienceForm(selected.Id);

            form.ShowDialog();
        }

        private void dgvCompleted_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCompleted.Columns[e.ColumnIndex].Name != "colExperience") return;

            TestDrive? testDrive = dgvCompleted.Rows[e.RowIndex].DataBoundItem as TestDrive;
            if (testDrive == null) return;

            e.Value = _experienceService.ExistsForTestDrive(testDrive.Id)
                ? "✔ bekijken"
                : "Ervaring invullen";
        }

        private void btnOpenStatistics_Click(object sender, EventArgs e)
        {
            new StatisticsForm().Show();
        }
        private void chkShowCancelled_CheckedChanged(object sender, EventArgs e)
        {
            LoadScheduledTestDrives();
        }
    }
}
