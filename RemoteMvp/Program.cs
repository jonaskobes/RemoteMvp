using RemoteMvpLib;

namespace RemoteMvpClient
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
            var client = new RemoteActionAdapter("localhost", 11000);
            var clientController = new ClientPresenter(client);
            clientController.OpenUI(true);
        }
    }
}