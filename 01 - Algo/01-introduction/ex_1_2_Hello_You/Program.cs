namespace ex_1_2_Hello_You
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstName;

            Console.Write("Bonjour, veuillez saisir votre prénom : ");
            
            firstName = Console.ReadLine();

            Console.Write("Bonjour " + firstName);
        }
    }
}