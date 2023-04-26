namespace ex_3_1_Controler_saisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom;

            do
            {
                Console.WriteLine("Bonjour mon chou, quel est ton prénom ?");
                prenom = Console.ReadLine();
            }
            while (prenom.Length < 2);
            Console.WriteLine("Bonjour " + prenom);
        }
    }
}