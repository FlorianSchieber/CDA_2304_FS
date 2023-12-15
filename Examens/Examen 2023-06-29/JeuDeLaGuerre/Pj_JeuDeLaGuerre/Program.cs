using CL_JeuDeLaGuerre;

namespace Pj_JeuDeLaGuerre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerrier heros = new Guerrier("Celest123", 10);
            Guerrier ennemi1 = new Guerrier("bot1", 3);
            Guerrier ennemi2 = new Guerrier("bot2", 4);
            Guerrier ennemi3 = new Guerrier("bot3", 1);
            Guerrier ennemi4 = new Guerrier("bot4", 0);

            Medecin docteurMaboule = new Medecin("MaboulDu68");

            docteurMaboule.Soigner(heros);

            heros.AjouterArme("bâton de bouleau", 1);
            ennemi1.AjouterArme("fusil à pompe", 10);
            ennemi2.AjouterArme("canon portatif", 50);
            ennemi3.AjouterArme("char d'assaut", 100);
            ennemi4.AjouterArme("sabre laser", 30);

            if (heros.Attaquer(new List<Guerrier> { ennemi1, ennemi2, ennemi3, ennemi4 }))
            {
                Console.WriteLine("Attaque réussie");
            }
            else
            {
                Console.WriteLine("Attaque loupée");
            }

            docteurMaboule.Soigner(heros);
            heros.AjouterArme("Bouton rouge du Président", 1000);
            heros.RetirerArme(0);
            if (heros.Attaquer(new List<Guerrier> { ennemi1, ennemi2, ennemi3, ennemi4 }))
            {
                Console.WriteLine("Attaque réussie");
            }
            else
            {
                Console.WriteLine("Attaque loupée");
            }

        }
    }
}