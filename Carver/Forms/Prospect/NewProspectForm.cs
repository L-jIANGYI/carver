using Carver.Services;
using ProspectModel = Carver.Models.Prospect;

namespace Carver.Forms.Prospect
{
    internal class NewProspectForm : ProspectForm
    {
        private readonly ProspectService _prospectService = new ProspectService();

        public NewProspectForm()
        {
            this.Text = "Nieuwe Prospect";
            lblProspect.Text = "Nieuwe Prospect";
            btnSubmit.Text = "Aanmaken";
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ProspectModel prospect = new ProspectModel(
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    txtAddress.Text,
                    txtCity.Text
                )
                {
                    HasDrivingLicense = chkDrivingLicense.Checked,
                    HasScooterLicense = chkScooterLicense.Checked,
                    IsDisabledVehicle = chkDisabledVehicle.Checked
                };

                _prospectService.Add(prospect);

                MessageBox.Show("Prospect aangemaakt.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validatiefout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
