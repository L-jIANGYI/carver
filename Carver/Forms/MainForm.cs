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
            dgvProspects.DataSource = _prospectService.GetAll();
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
    }
}
