using Carver.Models;

namespace Carver
{
    internal partial class MainForm : Form
    {
        public bool IsLogout { get; private set; } = false;

        public MainForm(User user)
        {
            InitializeComponent();
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
    }
}
