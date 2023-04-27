namespace ex_3_5_Nombre_premier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int divisor;
            bool isComposite;

            Console.Write("Veuillez entrer un nombre : ");
            N = int.Parse(Console.ReadLine());
            if (N > 1)
            {
                isComposite = false;
                divisor = 2;
                while (!isComposite && divisor < N)
                {
                    isComposite = N % divisor == 0;
                    divisor++;
                }
                if (isComposite)
                {
                    Console.Write(N + " est composé.");
                }
                else
                {
                    Console.Write(N + " est premier.");
                }
            }
            else
            {
                Console.WriteLine("Par définition, " + N + " n'est pas premier.");
            }
        }
    }
}