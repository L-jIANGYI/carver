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
        private List<Prospect> _allProspects;
        private Prospect? _selectedProspect;

        public MainForm(User user)
        {
            InitializeComponent();

            lblWelcome.Text = $"Welkom, {user.Name}!";
            dgvProspects.AutoGenerateColumns = false;
            LoadProspects();
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

        private void txtSearchProspects_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearchProspects.Text.ToLower();

            if (string.IsNullOrWhiteSpace(query))
            {
                lstFilteredProspects.Visible = false;
                dgvProspects.DataSource = _allProspects;
                return;
            }

            var filtered = _allProspects
                .Where(p => p.FullName.ToLower().Contains(query))
                .ToList();

            lstFilteredProspects.DataSource = filtered;
            lstFilteredProspects.DisplayMember = "FullName";
            lstFilteredProspects.Visible = true;

            dgvProspects.DataSource = filtered;
        }

        private void txtSearchProspects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstFilteredProspects.Visible = false;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSearchProspect_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearchProspect.Text.ToLower();

            System.Diagnostics.Debug.WriteLine($"query: {query}, prospects count: {_allProspects?.Count}");


            if (string.IsNullOrWhiteSpace(query))
            {
                lstProspects.Visible = false;
                return;
            }

            var filtered = _allProspects
                .Where(p => p.FullName.ToLower().Contains(query))
                .ToList();

            lstProspects.DataSource = filtered;
            lstProspects.DisplayMember = "FullName";
            lstProspects.Visible = true;
        }

        private void txtSearchProspect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstProspects.Visible = false;
                e.SuppressKeyPress = true;
            }
        }

        private void lstProspects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProspect = lstProspects.SelectedItem as Prospect;
            if (_selectedProspect == null) return;

            lblFirstName.Text = _selectedProspect.FullName;
            lblLastName.Text = _selectedProspect.Email;
            lblEmail.Text = _selectedProspect.Phone;
            lblPhone.Text = _selectedProspect.Phone;
            lblAddress.Text = _selectedProspect.Address;
            lblCity.Text = _selectedProspect.City;
            chkHasDrivingLicense.Checked = _selectedProspect.HasDrivingLicense;
            chkHasScooterLicense.Checked = _selectedProspect.HasScooterLicense;
            chkIsDisabledVehicle.Checked = _selectedProspect.IsDisabledVehicle;

            lstProspects.Visible = false;
        }
    }
}
