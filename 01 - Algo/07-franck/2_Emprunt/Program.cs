namespace _2_Emprunt
{
    internal class Program
    {
        static double TronquerCentimes(double valeur)
        {
            return Math.Floor(valeur * 100) / 100;
        }

        static double tauxInteretMensuel(double tauxInteretAnnuel)
        {
            return tauxInteretAnnuel / 12;
        }

        static double mensualitePret(double txAnnuel, double K, int nbrAnneeRmbt)
        {
            double tm;
            double a;
            double Q;
            int n;

            tm = tauxInteretMensuel(txAnnuel);
            n = 12 * nbrAnneeRmbt;
            Q = 1 - Math.Pow((1 - tm), n);
            a = K * tm / Q;

            return a;
        }

        static void afficherTableauAmortissementPret(double txAnnuel, double capitalEmprunte, int nbAnneeRmbt)
        {
            double Kn;
            double partInteret;
            double partCapital;
            double tm;
            double mensualite;

            mensualite = mensualitePret(txAnnuel, capitalEmprunte, nbAnneeRmbt);
            tm = tauxInteretMensuel(txAnnuel);
            Kn = capitalEmprunte;
            partInteret = 0;
            partCapital = 0;
            Console.WriteLine("Mois\t\t| Part intérêt\t\t| Part capital\t\t| Capital restant \t\t| Mensualité");
            for (int n = 0; n <= nbAnneeRmbt * 12; n++)
            {
                Console.WriteLine(n + "\t\t| " + TronquerCentimes(partInteret) + "\t\t| " + TronquerCentimes(partCapital) + "\t\t| " + TronquerCentimes(Kn) + "\t\t| " + mensualite);
                partInteret = Kn * tm;
                partCapital = mensualite - partInteret;
                Kn -= partCapital;
            }
        }

        static void Main(string[] args)
        {
            double tauxInteretAnnuel;
            double capitalEmprunte;
            int nbrAnneeRbmt;

            Console.Write("Veuillez saisir le taux d'intérêt annuel : ");
            tauxInteretAnnuel = double.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir le capital emprunté : ");
            capitalEmprunte = double.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir le nombre d'années de remboursement : ");
            nbrAnneeRbmt = int.Parse(Console.ReadLine());

            afficherTableauAmortissementPret(tauxInteretAnnuel, capitalEmprunte, nbrAnneeRbmt);

        }
    }
}


