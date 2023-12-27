namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formLogin = new FormLogin();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                // Globals.User = formLogin.User;
                if (Globals.GatewayExists)
                {
                    Application.Run(new FormMain());
                }
                else
                {
                    Application.Run(new FormReport());
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}