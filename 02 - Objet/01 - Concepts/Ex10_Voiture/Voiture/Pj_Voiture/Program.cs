using CL_Voiture;

namespace Pj_Voiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture titine = new Voiture();

            titine.Avancer();
            titine.Freiner();
            titine.Demarrer();
            titine.Avancer();
            titine.Freiner();
        }
    }
}