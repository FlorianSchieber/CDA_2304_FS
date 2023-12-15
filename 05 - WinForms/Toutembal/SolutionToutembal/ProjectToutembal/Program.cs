using CL_Production;

namespace ProjectToutembal
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

            Production[] productions =
            {
                new Production("Production A", "A", 100, 1000, 0.01),
                new Production("Production B", "B", 250, 5000, 0.02),
                new Production("Production C", "C", 1200, 10000, 0.05)
            };

            ApplicationConfiguration.Initialize();
            Application.Run(new FormProductionManager(productions));
        }
    }
}