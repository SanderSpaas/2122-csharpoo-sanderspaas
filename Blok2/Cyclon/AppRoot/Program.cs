using LogicLayer;
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
            ICyclonMain cyclonMain = new Map();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(cyclonMain));
        }
    }
}