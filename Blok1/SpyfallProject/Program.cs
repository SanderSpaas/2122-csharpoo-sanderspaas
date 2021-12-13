using SpyfallProject.logischelaag;

namespace SpyfallProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SpyfallMain spel = new();
            Application.Run(new presentatielaag.startGui(spel));
        }
    }
}