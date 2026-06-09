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
        private readonly UserService _userService = new UserService();

        private List<Prospect> _allProspects = new List<Prospect>();
        private Prospect? _selectedProspect;
        private TestDrive? _editingTestDrive;

        public MainForm(User user)
        {
            InitializeComponent();

            lblWelcome.Text = $"Welkom, {user.Name}!";
            InitDataGridViews();
            InitStatusColumn();

            LoadDashboard();
            LoadProspects();
            LoadScheduledTestDrives();
            LoadCompletedTestDrives();
            LoadUsers();

            if (user.Role != UserRole.Administrator)
                tabMain.TabPages.Remove(tpEmployeeManagement);
        }

        private void InitDataGridViews()
        {
            dgvProspects.AutoGenerateColumns = false;
            dgvScheduled.AutoGenerateColumns = false;
            dgvCompleted.AutoGenerateColumns = false;
            dgvDashboard.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
        }

        private void InitStatusColumn()
        {
            var statusColumn = dgvScheduled.Columns["colStatus"] as DataGridViewComboBoxColumn;
            if (statusColumn == null) return;

            var statuses = Enum.GetValues(typeof(TestDriveStatus))
                .Cast<TestDriveStatus>()
                .Select(s => new { Value = s, Display = s.ToDisplayName() })
                .ToList();

            statusColumn.DataSource = statuses;
            statusColumn.DisplayMember = "Display";
            statusColumn.ValueMember = "Value";
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

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTestDriveForm();
        }
    }
}
