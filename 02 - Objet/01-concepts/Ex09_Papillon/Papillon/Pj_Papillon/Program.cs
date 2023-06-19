using CL_Papillon;

namespace Pj_Papillon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere monLepidoptere = new Lepidoptere();
            monLepidoptere.SeDeplacer();
            monLepidoptere.SeMetamorphoser();
            monLepidoptere.SeDeplacer();
            monLepidoptere.SeMetamorphoser();
            monLepidoptere.SeDeplacer();
            monLepidoptere.SeMetamorphoser();
            monLepidoptere.SeDeplacer();

        }
    }
}