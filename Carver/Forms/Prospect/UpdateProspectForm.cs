namespace Carver.Forms.Prospect
{
    internal class UpdateProspectForm : ProspectForm
    {
        private int _prospectId;

        public UpdateProspectForm(int prospectId)
        {
            this._prospectId = prospectId;

            this.Text = "Prospect Bewerken";
            lblProspect.Text = "Prospect Bewerken";
            btnSubmit.Text = "Opslaan";

            LaadProspect(_prospectId);
        }

        private void LaadProspect(int id)
        {
            
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
