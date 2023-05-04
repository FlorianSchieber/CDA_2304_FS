namespace ex_3_1_Controler_saisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;

            do
            {
                Console.WriteLine("Bonjour, veuillez saisir votre prénom (2 caractères minimum) : ");
                firstName = Console.ReadLine();
            }
            while (firstName.Length < 2);
            Console.WriteLine("Bonjour " + firstName);
        }
    }
}