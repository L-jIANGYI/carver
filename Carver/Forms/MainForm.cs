using Carver.Forms;
using Carver.Forms.Prospect;
using Carver.Models;
using Carver.Services;

namespace Carver
{
    internal partial class MainForm : Form
    {
        public bool IsLogout { get; private set; } = false;
        private readonly ProspectService _prospectService = new ProspectService();
        private readonly TestDriveService _testDriveService = new TestDriveService();
        private List<Prospect> _allProspects = new List<Prospect>();
        private Prospect? _selectedProspect;

        public MainForm(User user)
        {
            InitializeComponent();

            lblWelcome.Text = $"Welkom, {user.Name}!";
            InitDataGridView();
            LoadProspects();
            LoadScheduledTestDrives();
            LoadCompletedTestDrives();

            var statusColumn = (DataGridViewComboBoxColumn)dgvScheduled.Columns["colStatus"];
            statusColumn.DataSource = Enum.GetValues(typeof(TestDriveStatus));

        }

        private void InitDataGridView()
        {
            dgvProspects.AutoGenerateColumns = false;
            dgvScheduled.AutoGenerateColumns = false;
            dgvCompleted.AutoGenerateColumns = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Wil je uitloggen?", "Uitloggen",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                IsLogout = true;
                this.Close();
            }
        }

        // =======================================
        // Prospects tabpage
        // =======================================
        private void LoadProspects()
        {
            _allProspects = _prospectService.GetAll();
            dgvProspects.DataSource = _allProspects;
        }

        private void btnNewProspect_Click(object sender, EventArgs e)
        {
            NewProspectForm form = new NewProspectForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadProspects();
        }

        private void dgvProspects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Prospect? selected = dgvProspects.Rows[e.RowIndex].DataBoundItem as Prospect;
            if (selected == null) return;

            if (e.ColumnIndex == colEdit.Index)
            {
                EditProspectForm form = new EditProspectForm(selected.Id);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadProspects();
            }
            else if (e.ColumnIndex == colDelete.Index)
            {
                var result = MessageBox.Show($"Weet je zeker dat je {selected.FullName} wilt verwijderen?",
                    "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _prospectService.Delete(selected);

                    MessageBox.Show("Prospect verwijderd.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadProspects();
                }
            }
        }

        private void DisplaySelectedProspect(Prospect prospect)
        {
            _selectedProspect = prospect;
            lblFirstName.Text = prospect.FirstName;
            lblLastName.Text = prospect.LastName;
            lblEmail.Text = prospect.Email;
            lblPhone.Text = prospect.Phone;
            lblAddress.Text = prospect.Address;
            lblCity.Text = prospect.City;
            chkHasDrivingLicense.Checked = prospect.HasDrivingLicense;
            chkHasScooterLicense.Checked = prospect.HasScooterLicense;
            chkIsDisabledVehicle.Checked = prospect.IsDisabledVehicle;
        }

        private void txtSearchProspects_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearchProspects.Text.ToLower();

            if (string.IsNullOrWhiteSpace(query))
            {
                lstFilteredProspects.Visible = false;
                dgvProspects.DataSource = _allProspects;
                return;
            }

            var filtered = _prospectService.Search(_allProspects, query);
            lstFilteredProspects.DataSource = filtered;
            lstFilteredProspects.DisplayMember = "FullName";
            lstFilteredProspects.Visible = true;
            dgvProspects.DataSource = filtered;
        }

        private void lstFilteredProspects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prospect? selected = lstFilteredProspects.SelectedItem as Prospect;
            if (selected == null) return;

            dgvProspects.DataSource = new List<Prospect> { selected };
            lstFilteredProspects.Visible = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            if (sender == txtSearchProspects)
                lstFilteredProspects.Visible = false;
            else if (sender == txtSearchProspect)
                lstProspects.Visible = false;

            e.SuppressKeyPress = true;
        }

        // =======================================
        // TestDrive tabpage - prospect search & select
        // =======================================
        private void txtSearchProspect_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearchProspect.Text.ToLower();

            if (string.IsNullOrWhiteSpace(query))
            {
                lstProspects.Visible = false;
                return;
            }

            var filtered = _prospectService.Search(_allProspects, query);
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

        // =======================================
        // TestDrive tabpage - testdrive details & actions
        // =======================================

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

                TestDrive testDrive = new TestDrive(
                    _selectedProspect,
                    carver,
                    dtpTestDriveDateTime.Value,
                    rtbInterestReason.Text.Trim()
                );

                _testDriveService.Add(testDrive);

                MessageBox.Show("Proefrit ingepland.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetTestDriveForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetTestDriveForm()
        {
            rtbInterestReason.Clear();
            dtpTestDriveDateTime.Value = DateTime.Now;

            _selectedProspect = null;
            txtSearchProspect.Clear();
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

        private void LoadScheduledTestDrives()
        {
            var testDrives = _testDriveService.GetByStatus(TestDriveStatus.Scheduled);
            dgvScheduled.DataSource = testDrives;
        }

        private void LoadCompletedTestDrives()
        {
            var testDrives = _testDriveService.GetByStatus(TestDriveStatus.Completed);
            dgvCompleted.DataSource = testDrives;
        }

        private void dgvScheduled_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colStatus.Index) return;

            TestDrive? testDrive = dgvScheduled.Rows[e.RowIndex].DataBoundItem as TestDrive;
            if (testDrive == null) return;

            TestDriveStatus newStatus = (TestDriveStatus)dgvScheduled.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            _testDriveService.UpdateStatus(testDrive.Id, newStatus);

            LoadScheduledTestDrives();
            LoadCompletedTestDrives();
        }
    }
}
