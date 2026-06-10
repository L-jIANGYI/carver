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

        // search
        private void HandleProspectSearch(string query, ListBox lst, DataGridView dgv, List<Prospect> allItems)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                lst.Visible = false;
                dgv.DataSource = allItems.ToList();
                return;
            }

            var filtered = _prospectService.Search(query);
            lst.DataSource = filtered;
            lst.DisplayMember = "FullName";
            lst.Visible = filtered.Count > 0;
            dgv.DataSource = filtered.ToList();
        }

        private void HandleProspectSelected(ListBox lst, TextBox txt, DataGridView dgv)
        {
            Prospect? selected = lst.SelectedItem as Prospect;
            if (selected == null) return;

            txt.Text = selected.FullName;
            dgv.DataSource = new List<Prospect> { selected };
            lst.Visible = false;
        }

        private void HandleTestDriveSearch(string query, ListBox lst, DataGridView dgv, TestDriveStatus status)
        {
            var all = _testDriveService.GetByStatus(status);

            if (!string.IsNullOrWhiteSpace(query))
            {
                var matched = all.Where(t => t.ProspectName.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
                lst.DataSource = matched;
                lst.DisplayMember = "ProspectName";
                lst.Visible = matched.Count > 0;
                dgv.DataSource = matched;
            }
            else
            {
                lst.Visible = false;
                dgv.DataSource = all;
            }
        }

        private void HandleTestDriveSelected(ListBox lst, TextBox txt, DataGridView dgv)
        {
            TestDrive? selected = lst.SelectedItem as TestDrive;
            if (selected == null) return;

            txt.Text = selected.ProspectName;
            dgv.DataSource = new List<TestDrive> { selected };
            lst.Visible = false;
        }

        private void HandleSearchKeyDown(KeyEventArgs e, ListBox lst, TextBox txt, Action onEnter)
        {
            if (e.KeyCode != Keys.Enter) return;

            if (lst.Visible && lst.SelectedItem != null)
                onEnter();
            else
                lst.Visible = false;

            e.SuppressKeyPress = true;
        }
    }
}
