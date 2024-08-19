using EducationCenter.Presenters;

namespace EducationCenter
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
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IMainView mainView = new MainView();
            new MainPresenter(mainView);
            ILoginView loginView = new LoginView();
            new LoginPresenter(loginView);
            Application.Run((Form)loginView);
            if (loginView.IsSuccessfull)
            {
                loginView.Close();
                Application.Run((Form)mainView);
            }
        }
    }
}