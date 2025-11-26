

namespace КР_ПИ
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ensure data folder and files exist
            Directory.CreateDirectory(DataStore.DataFolder);
            DataStore.EnsureInitialized();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var loginForm = new LoginForm();
            Application.Run(loginForm);
        }
    }
}