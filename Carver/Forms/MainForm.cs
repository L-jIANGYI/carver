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
        private readonly ExperienceService _experienceService = new ExperienceService();
        private List<Prospect> _allProspects = new List<Prospect>();
        private Prospect? _selectedProspect;
        private TestDrive? _editingTestDrive;

        public MainForm(User user)
        {
            InitializeComponent();

            lblWelcome.Text = $"Welkom, {user.Name}!";
            InitDataGridView();
            LoadProspects();
            LoadScheduledTestDrives();
            LoadCompletedTestDrives();
            LoadDashboard();

            var statusColumn = dgvScheduled.Columns["colStatus"] as DataGridViewComboBoxColumn;
            if (statusColumn != null)
            {
                var statuses = Enum.GetValues(typeof(TestDriveStatus))
                    .Cast<TestDriveStatus>()
                    .Select(s => new
                    {
                        Value = s,
                        Display = s switch
                        {
                            TestDriveStatus.Scheduled => "Gepland",
                            TestDriveStatus.Completed => "Uitgevoerd",
                            TestDriveStatus.Canceled => "Geannuleerd",
                            _ => s.ToString()
                        }
                    })
                    .ToList();

                statusColumn.DataSource = statuses;
                statusColumn.DisplayMember = "Display";
                statusColumn.ValueMember = "Value";
            }
        }

        private void InitDataGridView()
        {
            dgvProspects.AutoGenerateColumns = false;
            dgvScheduled.AutoGenerateColumns = false;
            dgvCompleted.AutoGenerateColumns = false;
            dgvDashboard.AutoGenerateColumns = false;
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
        // Dashboard tabpage
        // =======================================
        private void LoadDashboard()
        {
            var scheduled = _testDriveService.GetByStatus(TestDriveStatus.Scheduled);
            var completed = _testDriveService.GetByStatus(TestDriveStatus.Completed);

            lblTotalScheduled.Text = scheduled.Count.ToString();
            lblTotalCompleted.Text = completed.Count.ToString();

            var recent = scheduled
                .OrderBy(t => t.ScheduledAt)
                .Take(5)
                .ToList();

            dgvDashboard.DataSource = recent;
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
                _selectedProspect = form.CreatedProspect;
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

                if (_editingTestDrive != null)
                {
                    // Update existing
                    _editingTestDrive.Prospect = _selectedProspect;
                    _editingTestDrive.Carver = carver;
                    _editingTestDrive.ScheduledAt = dtpTestDriveDateTime.Value;
                    _editingTestDrive.Reason = rtbInterestReason.Text.Trim();

                    _testDriveService.Update(_editingTestDrive);
                    _editingTestDrive = null;

                    MessageBox.Show("Proefrit bijgewerkt.", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Create new
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

                btnTestDriveSubmit.Text = "Proefrit inplannen";
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

        private void ResetTestDriveForm()
        {
            rtbInterestReason.Clear();
            dtpTestDriveDateTime.Value = DateTime.Now;
            btnTestDriveSubmit.Text = "Proefrit inplannen";

            _editingTestDrive = null;
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

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTestDriveForm();
        }

        private void dgvCompleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colExperience.Index) return;

            TestDrive? selected = dgvCompleted.Rows[e.RowIndex].DataBoundItem as TestDrive;
            if (selected == null) return;

            Experience? existing = _experienceService.GetByTestDriveId(selected.Id);
            if (existing != null)
            {
                ExperienceForm form = new ExperienceForm(selected.Id, existing);
                form.ShowDialog();
                return;
            }

            ExperienceForm newForm = new ExperienceForm(selected.Id);
            newForm.ShowDialog();
        }

        private void dgvCompleted_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCompleted.Columns[e.ColumnIndex].Name != "colExperience") return;

            TestDrive? testDrive = dgvCompleted.Rows[e.RowIndex].DataBoundItem as TestDrive;
            if (testDrive == null) return;

            bool hasExperience = _experienceService.ExistsForTestDrive(testDrive.Id);
            e.Value = hasExperience ? "✔ bekijken" : "Ervaring invullen";
        }

        private void btnOpenStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm();
            form.Show();
        }
    }
}