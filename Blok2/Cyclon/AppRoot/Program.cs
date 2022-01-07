using Globals.Interfaces;
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
            IData data = new DataAccessLayer.Data();
            ILogic logic = new CyclonMain(data);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(logic, data));
        }
    }
}