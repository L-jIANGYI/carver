using Carver.Models;
using Carver.Services;

namespace Carver.Forms
{
    /// <summary>
    /// Wordt getoond als er nog geen administrator bestaat.
    /// Laat de gebruiker zelf een admin-account aanmaken.
    /// </summary>
    internal partial class SetupAdminForm : Form
    {
        // ----------------------------------------------------------------
        // Controls
        // ----------------------------------------------------------------
        private Label lblTitle = new Label();
        private Label lblSubtitle = new Label();
        private Label lblName = new Label();
        private Label lblEmail = new Label();
        private Label lblPassword = new Label();
        private Label lblConfirm = new Label();
        private TextBox txtName = new TextBox();
        private TextBox txtEmail = new TextBox();
        private TextBox txtPassword = new TextBox();
        private TextBox txtConfirm = new TextBox();
        private Button btnCreate = new Button();
        private Label lblError = new Label();

        private readonly UserService _userService = new UserService();

        // ----------------------------------------------------------------
        // Constructor
        // ----------------------------------------------------------------
        public SetupAdminForm()
        {
            BuildLayout();
        }

        // ----------------------------------------------------------------
        // Layout (geen Designer — zo geen extra .Designer.cs nodig)
        // ----------------------------------------------------------------
        private void BuildLayout()
        {
            this.Text = "Carver – Eerste installatie";
            this.Size = new Size(420, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // Sluiten mag niet: er MOET een admin zijn
            this.ControlBox = false;

            // Titel
            lblTitle.Text = "Welkom bij Carver";
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(24, 20);

            lblSubtitle.Text = "Maak een administrator-account aan om te beginnen.";
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(24, 52);
            lblSubtitle.ForeColor = Color.Gray;

            // Naam
            lblName.Text = "Naam";
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 90);

            txtName.Location = new Point(24, 110);
            txtName.Width = 360;

            // E-mail
            lblEmail.Text = "E-mailadres";
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 145);

            txtEmail.Location = new Point(24, 165);
            txtEmail.Width = 360;

            // Wachtwoord
            lblPassword.Text = "Wachtwoord";
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 200);

            txtPassword.Location = new Point(24, 220);
            txtPassword.Width = 360;
            txtPassword.PasswordChar = '•';

            // Bevestig wachtwoord
            lblConfirm.Text = "Wachtwoord bevestigen";
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(24, 255);

            txtConfirm.Location = new Point(24, 275);
            txtConfirm.Width = 360;
            txtConfirm.PasswordChar = '•';

            // Foutmelding
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Crimson;
            lblError.Location = new Point(24, 315);
            lblError.Text = "";

            // Knop
            btnCreate.Text = "Account aanmaken";
            btnCreate.Size = new Size(360, 36);
            btnCreate.Location = new Point(24, 340);
            btnCreate.Click += BtnCreate_Click;

            // Alles toevoegen
            this.Controls.AddRange(new Control[]
            {
                lblTitle, lblSubtitle,
                lblName, txtName,
                lblEmail, txtEmail,
                lblPassword, txtPassword,
                lblConfirm, txtConfirm,
                lblError, btnCreate
            });
        }

        // ----------------------------------------------------------------
        // Logica
        // ----------------------------------------------------------------
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // Validatie
            if (string.IsNullOrWhiteSpace(name))
            {
                lblError.Text = "Voer een naam in.";
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                lblError.Text = "Voer een geldig e-mailadres in.";
                return;
            }

            if (password.Length < 6)
            {
                lblError.Text = "Wachtwoord moet minimaal 6 tekens zijn.";
                return;
            }

            if (password != confirm)
            {
                lblError.Text = "Wachtwoorden komen niet overeen.";
                return;
            }

            try
            {
                Administrator admin = new Administrator(name, email, password);
                _userService.Register(admin);

                MessageBox.Show(
                    $"Administrator '{name}' is aangemaakt.\nU kunt nu inloggen.",
                    "Klaar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Fout: " + ex.Message;
            }
        }
    }
}