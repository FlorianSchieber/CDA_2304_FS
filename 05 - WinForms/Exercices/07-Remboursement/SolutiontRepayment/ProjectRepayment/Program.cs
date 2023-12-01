using CL_Repayment;

namespace ProjectRepayment
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

            FormRepayment creationForm = new FormRepayment();

            Application.Run(creationForm);


            Repayment myRepayment = creationForm.InoutRepayment;

            FormRepayment editionForm = new FormRepayment(myRepayment);

            Application.Run(editionForm);

            FormRepayment editionForm2 = new FormRepayment(myRepayment);

            Application.Run(editionForm2);
        }
    }
}