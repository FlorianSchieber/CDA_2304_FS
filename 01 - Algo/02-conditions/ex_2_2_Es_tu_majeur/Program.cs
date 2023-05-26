namespace ex_2_2_Es_tu_majeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;

            Console.WriteLine("Veuillez entrer votre âge (en années) : ");
            A = int.Parse(Console.ReadLine());

            if (A < 0)
            {
                Console.WriteLine("Vous n'êtes pas encore né");
            }
            else if (A < 18)
            {
                Console.WriteLine("Vous êtes mineur");
            }
            else
            {
                Console.WriteLine("Vous êtes majeur");
            }
        }
    }
}