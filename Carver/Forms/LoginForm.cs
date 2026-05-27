using Carver.Models;
using Carver.Services;

namespace Carver
{
    internal partial class LoginForm : Form
    {
        public User? LoggedInUser { get; private set; }
        private readonly UserService _userService = new UserService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? user = _userService.Login(txtEmail.Text, txtPassword.Text);

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
