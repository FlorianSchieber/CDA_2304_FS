using CL_CompteBancaire;

namespace Pj_CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire c = new CompteBancaire(0);
            CompteBancaire c1 = new CompteBancaire(12345, "toto", 1000, -500);

            Console.WriteLine(c);
            Console.WriteLine(c1);
        }
    }
}