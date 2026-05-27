namespace Carver.Forms.Prospect
{
    internal class EditProspectForm : ProspectForm
    {
        private int _prospectId;

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
            
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
