using PresentationLayer;

namespace AppRoot
{
    internal static class Program
    {
        /// <summary>
        ///  Composition root for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}