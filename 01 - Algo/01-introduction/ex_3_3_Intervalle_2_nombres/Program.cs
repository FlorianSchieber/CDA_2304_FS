namespace ex_3_3_Intervalle_2_nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;

            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Résultat =");
            if (A < B)
            {
                for (int i = A + 1; i < B; i++)
                {
                    Console.Write(" " + i);
                }
            }
            else
            {
                for (int i = A - 1; i > B; i--)
                {
                    Console.Write(" " + i);
                    
                }
            }

        }
    }
}