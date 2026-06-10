using Carver.Forms.Prospect;
using Carver.Helpers;
using Carver.Models;

namespace Carver
{
    internal partial class MainForm
    {
        private void LoadProspects()
        {
            _allProspects = _prospectService.GetAll();
            dgvProspects.DataSource = _allProspects;
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
                var result = MessageBox.Show(
                    $"Weet je zeker dat je {selected.FullName} wilt verwijderen?",
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
            HandleProspectSearch(txtSearchProspects.Text.Trim(), lstFilteredProspects, dgvProspects, _allProspects);
        }

        private void lstFilteredProspects_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleProspectSelected(lstFilteredProspects, txtSearchProspects, dgvProspects);
        }

        private void txtSearchProspects_KeyDown(object sender, KeyEventArgs e)
        {
            HandleSearchKeyDown(e, lstFilteredProspects, txtSearchProspects,
                () => HandleProspectSelected(lstFilteredProspects, txtSearchProspects, dgvProspects));
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            var prospects = dgvProspects.DataSource as List<Prospect>;

            if (prospects == null || prospects.Count == 0)
            {
                MessageBox.Show(
                    "Er zijn geen klanten om te exporteren.",
                    "Lege lijst",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ExcelExportHelper.ExportProspectenLijst(prospects);
        }
    }
}
