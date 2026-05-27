using Carver.Services;
using ProspectModel = Carver.Models.Prospect;

namespace Carver.Forms.Prospect
{
    internal class EditProspectForm : ProspectForm
    {
        private int _prospectId;
        private readonly ProspectService _prospectService = new ProspectService();

        public EditProspectForm(int prospectId)
        {
            this._prospectId = prospectId;

            this.Text = "Prospect Bewerken";
            lblProspect.Text = "Prospect Bewerken";
            btnSubmit.Text = "Opslaan";

            LaadProspect(_prospectId);
        }

        private void LaadProspect(int id)
        {
            ProspectModel? prospect = _prospectService.GetById(id);
            if (prospect != null)
            {
                txtFirstName.Text = prospect.FirstName;
                txtLastName.Text = prospect.LastName;
                txtEmail.Text = prospect.Email;
                txtPhone.Text = prospect.Phone;
                txtAddress.Text = prospect.Address;
                txtCity.Text = prospect.City;
                chkHasDrivingLicense.Checked = prospect.HasDrivingLicense;
                chkHasScooterLicense.Checked = prospect.HasScooterLicense;
                chkIsDisabledVehicle.Checked = prospect.IsDisabledVehicle;
            }
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ProspectModel updatedProspect = new ProspectModel(
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtCity.Text.Trim()
                )
                {
                    Id = _prospectId,
                    HasDrivingLicense = chkHasDrivingLicense.Checked,
                    HasScooterLicense = chkHasScooterLicense.Checked,
                    IsDisabledVehicle = chkIsDisabledVehicle.Checked
                };

                _prospectService.Update(updatedProspect);

                MessageBox.Show("Prospect bijgewerkt!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij het bijwerken van de prospect: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
