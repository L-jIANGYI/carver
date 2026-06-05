using Carver.Models;
using Carver.Services;

namespace Carver.Forms
{
    public partial class UserForm : Form
    {
        private readonly UserService _userService = new UserService();

        public UserForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            UserRole role = rbEmployee.Checked ? UserRole.Employee : UserRole.Administrator;

            User user = new User(name, email, password, role);


            try
            {
                _userService.Register(user);
                MessageBox.Show("Nieuwe gebruiker toegevoegd.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij opslaan: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
