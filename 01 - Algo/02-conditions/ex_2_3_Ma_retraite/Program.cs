namespace ex_2_3_Ma_retraite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int X;
            bool AIsInt;

            Console.WriteLine("Veuillez entrer votre âge (en années) : ");
            AIsInt = int.TryParse(Console.ReadLine(), out A);
            if (AIsInt){
                X = A - 60;

                if (A < 0)
                {
                    Console.WriteLine("La valeur fournie n'est pas un âge valide.");
                }
                else if (X > 0)
                {
                    Console.WriteLine("Vous êtes à la retraite depuis " + X + " années.");
                }
                else if (X < 0)
                {
                    Console.WriteLine("Il vous reste " + (-X) + " années avant la retraite.");
                }
                else
                {
                    Console.WriteLine("C'est le moment de prendre sa retraite.");
                }
            }
            else
            {
                Console.WriteLine("La valeur fournie n’est pas un âge valide.");
            }
        }
    }
}