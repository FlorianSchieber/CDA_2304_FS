namespace ex_2_1_Tri_nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;

            Console.WriteLine("Veuillez entrer un nombre A entier : ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer un nombre B entier : ");
            B = int.Parse(Console.ReadLine());

            if (A < B)
            {
                Console.WriteLine(A + " < " + B);
            }
            else
            {
                Console.WriteLine(B + " <= " + A);
            }
        }
    }
}