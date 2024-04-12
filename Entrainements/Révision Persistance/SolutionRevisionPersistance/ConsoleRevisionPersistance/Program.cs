using CL_Personne;

internal class Program
{
    private static void Main(string[] args)
    {
        PersistancePersonne persistance = new PersistancePersonne();

        Personne francky = new Personne("Francky", "VINCENT");

        francky.Save(persistance);

    }
}