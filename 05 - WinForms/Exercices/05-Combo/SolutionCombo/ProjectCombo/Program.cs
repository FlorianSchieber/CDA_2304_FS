namespace ProjectCombo
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

            Dictionary<string, bool> startCheckedCountries = new Dictionary<string, bool>
            {
                { "France", false },
                { "Belgique", false },
                { "Allemagne", false },
                { "Japon", false },
                { "Portugal", false },
                { "Grèce", false }
            };

            FormCombo creationForm = new FormCombo(startCheckedCountries);

            Application.Run(creationForm);

            Dictionary<string, bool> editedCheckedCountries = creationForm.CheckedCountries;
            FormCombo editionForm = new FormCombo(editedCheckedCountries);

            Application.Run(editionForm);


        }
    }
}