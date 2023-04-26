namespace ex_1_2_Hello_You
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String prenom;

            Console.WriteLine("Bonjour, veuillez saisir votre prénom : ");
            
            prenom = Console.ReadLine();

            Console.WriteLine("Bonjour " + prenom);
        }
    }
}