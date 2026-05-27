namespace Carver.Forms.Prospect
{
    internal class NewProspectForm : ProspectForm
    {
        public NewProspectForm()
        {
            this.Text = "Nieuwe Prospect";
            lblProspect.Text = "Nieuwe Prospect";
            btnSubmit.Text = "Aanmaken";
        }

        protected override void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
