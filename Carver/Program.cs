namespace Carver
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

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

            //Application.Run(new MainForm());
        }
    }
}