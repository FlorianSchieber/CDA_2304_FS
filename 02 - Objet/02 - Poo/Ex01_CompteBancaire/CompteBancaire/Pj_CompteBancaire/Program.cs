using CL_CompteBancaire;

namespace Pj_CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire c = new CompteBancaire(0);
            CompteBancaire c0 = new CompteBancaire(12345, "toto", "Eur", 1000, -500);
            Console.WriteLine(c);
            Console.WriteLine(c0);

            CompteBancaire b = new CompteBancaire(545454, "Laurent", "Eur", 2000, -500);
            b.Crediter(100);
            Console.WriteLine(b);
            bool ok = b.Debiter(100000);
            if (ok)
            {
                Console.WriteLine("Débit réussi !");
            }
            else
            {
                Console.WriteLine("Débit échoué !");
            }

            CompteBancaire c1 = new CompteBancaire(12345, "toto", "Eur", 1000, -500);
            CompteBancaire c2 = new CompteBancaire(45657, "titi", "Eur", 2000, -1000);
            c1.TransfererVers(c2, 1300);
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            CompteBancaire c3 = new CompteBancaire(12345, "toto", "USD", 1000, -500);
            CompteBancaire c4 = new CompteBancaire(45657, "titi", "USD", 2000, -1000);
            if (c3.EstSuperieurA(c4))
            {
                Console.WriteLine("Supérieur !");
            }
            else
            {
                Console.WriteLine("Inférieur !");
            }
        }
    }
}