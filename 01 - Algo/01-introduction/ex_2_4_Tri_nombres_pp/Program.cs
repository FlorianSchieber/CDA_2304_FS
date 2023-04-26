namespace ex_2_4_Tri_nombres_pp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;

            Console.WriteLine("Veuillez saisir le nombre A : ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre B : ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre C : ");
            C = int.Parse(Console.ReadLine());

            if (A < B)
            {
                if (B < C)
                {
                    Console.WriteLine(C + " > " + B + " > " + A);
                }
                else
                {
                    if (A < C)
                    {
                        Console.WriteLine(B + " >= " + C + " > " + A);
                    }
                    else
                    {
                        Console.WriteLine(B + " > " + A + " >= " + C);
                    }
                }
            }
            else
            {
                if (B < C)
                {
                    if (A < C)
                    {
                        Console.WriteLine(C + " > " + A + " >= " + B);
                    }
                    else
                    {
                        Console.WriteLine(A + " >= " + C + " > " + B);
                    }
                }
                else
                {
                    Console.WriteLine(A + " >= " + B + " >= " + C);
                }
            }
        }
    }
}