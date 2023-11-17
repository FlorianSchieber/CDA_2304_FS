using CL_Transaction;
using CL_Serializer;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjetTransactions
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

            List<Transaction> transactions = new List<Transaction> { };

            FormTransactions createFT = new FormTransactions();
            Application.Run(createFT);
            transactions.Add(createFT.CurrentTransaction);

            Serializer.JsonSerialize(transactions[0]);
            transactions.Add(Serializer.JsonDeserialize());


            FormTransactions editFT = new FormTransactions(transactions[1]);
            Application.Run(editFT);
            
        }
    }
}