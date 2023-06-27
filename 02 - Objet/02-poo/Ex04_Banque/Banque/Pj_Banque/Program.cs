using CL_Banque;

namespace Pj_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque("Credit Mututu", "Mulhouse");
            b.AjouterCompte(1245, "Robert", "Eur", 2000, -300);
            b.AjouterCompte(2568, "Denis", "Eur", 1000, -300);

            if (b.AjouterCompte(2568, "Denis", "Eur", 1000, -300))
            {
                Console.WriteLine("Deux comptes de même id !");
            }
            else
            {
                Console.WriteLine("Interdit de créer un compte avec un id existant !");
            }

            Console.WriteLine(b);
            b.CompteSuperieur();

            Console.WriteLine("Le compte d'id 2568 est : " + b.DonneCompte(2568));

            if (b.Transferer(1245, 2568, 1000))
            {
                Console.WriteLine("Transfert effectué");
            }
            else
            {
                Console.WriteLine("Transfert impossible");
            }

            if (b.Transferer(1245, 2568, 5000))
            {
                Console.WriteLine("Transfert effectué");
            }
            else
            {
                Console.WriteLine("Transfert impossible");
            }
            
            Console.WriteLine(b);

        }
    }
}