namespace ex_3_4_Diviseurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Veuillez entrer un nombre entier : ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Les diviseurs de " + number + " sont :");
            for (int divisor = 2; divisor < number; divisor++)
            {
                if (number % divisor == 0)
                {
                    Console.Write(" " + divisor);
                }
            }
        }
    }
}