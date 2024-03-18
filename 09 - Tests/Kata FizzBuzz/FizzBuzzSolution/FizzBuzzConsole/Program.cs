using CL_FizzBuzz;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void RunFizzBuzz()
    {
        const int min = 1;
        const int max = 100;

        for (int nombre = min; nombre <= max; nombre++)
        {
            Console.WriteLine(FizzBuzzToolTDD.FizzBuzz(nombre));
        }
    }

    private static void Main(string[] args)
    {
        Program.RunFizzBuzz();
    }
}