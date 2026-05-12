using Carver.Database;
using Carver.Models;

namespace Carver
{
    internal partial class LoginForm : Form
    {
        public User? LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();
            User? user = repo.Login(txtEmail.Text, txtPassword.Text);

            if (user != null)
            {
                LoggedInUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Onjuiste gegevens", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
