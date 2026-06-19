using Carver.Database;
using Carver.Forms;

namespace Carver
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // ── Stap 1: zoek een werkende SQL Server-instantie ──────────────
            // DBConnection.GetConnection() detecteert automatisch welke
            // instantie beschikbaar is. Als geen enkele werkt, stoppen we hier.
            try
            {
                using var testConn = DBConnection.GetMasterConnection();
                testConn.Open();
            }
            catch (NoSqlServerException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "SQL Server niet gevonden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kan geen verbinding maken met de database:\n\n" + ex.Message,
                    "Verbindingsfout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // ── Stap 2: zorg dat de database en tabellen bestaan ────────────
            try
            {
                DatabaseSetup.EnsureDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Fout bij het aanmaken van de database:\n\n" + ex.Message,
                    "Installatiefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // ── Stap 3: eerste keer? Admin aanmaken ─────────────────────────
            if (DatabaseSetup.NeedsFirstAdmin())
            {
                SetupAdminForm setupForm = new SetupAdminForm();
                if (setupForm.ShowDialog() != DialogResult.OK)
                {
                    // Gebruiker heeft het scherm gesloten zonder admin aan te maken
                    return;
                }
            }

            // ── Stap 4: normale login-loop ──────────────────────────────────
            while (true)
            {
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK && loginForm.LoggedInUser != null)
                {
                    MainForm mainForm = new MainForm(loginForm.LoggedInUser);
                    mainForm.ShowDialog();

                    if (!mainForm.IsLogout)
                        break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}