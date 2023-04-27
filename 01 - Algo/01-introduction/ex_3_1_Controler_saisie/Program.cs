namespace ex_3_1_Controler_saisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;

            do
            {
                Console.WriteLine("Bonjour mon chou, quel est ton prénom ?");
                firstName = Console.ReadLine();
            }
            while (firstName.Length < 2);
            Console.WriteLine("Bonjour " + firstName);
        }
    }
}