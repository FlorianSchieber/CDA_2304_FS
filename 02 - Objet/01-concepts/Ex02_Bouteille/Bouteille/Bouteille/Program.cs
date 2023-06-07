namespace Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille bouteilleDeFlo = new Bouteille(0.7, "Don Papa");
            bouteilleDeFlo.Ouvrir();
            bouteilleDeFlo.Vider();
            Console.WriteLine(bouteilleDeFlo);

            Bouteille bouteilleDeGuillaume = new Bouteille(1.36, "Jack Daniel's pas cher au Carrefour");
            bouteilleDeGuillaume.Ouvrir();
            bouteilleDeGuillaume.Vider();
            Console.WriteLine(bouteilleDeGuillaume);

            Bouteille bouteilleDeNatana = new Bouteille(0.5, "Eau de la fontaine");
            bouteilleDeNatana.Ouvrir();
            bouteilleDeNatana.Vider(0.25);
            bouteilleDeNatana.Vider(0.25);
            bouteilleDeNatana.Remplir(0.5);
            bouteilleDeNatana.Fermer();
            Console.WriteLine(bouteilleDeNatana);

            Bouteille bouteilleDeKevin = new Bouteille(20, "Bouteille de coke");
            bouteilleDeKevin.Ouvrir();  
            bouteilleDeKevin.Vider(19.8);
            Console.WriteLine(bouteilleDeKevin);
        }
    }
}