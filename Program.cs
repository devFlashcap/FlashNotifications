namespace FlashNotifications
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (TrayIcon trayIcon = new TrayIcon())
            {
                trayIcon.Show();
            }
            ApplicationConfiguration.Initialize();
            Application.Run();
        }
    }