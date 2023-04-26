namespace ex_1_5_Secteur_circulaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R;
            double A;
            double aire;

            const double PI = Math.PI;

            Console.WriteLine("Veuillez saisir le rayon d'un cercle : ");
            R = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir l'angle en degrés du secteur circulaire : ");
            A = double.Parse(Console.ReadLine());

            aire = (PI * Math.Pow(R, 2) * A) / 360;

            Console.WriteLine("L'aire du secteur circulaire est : " + aire);
        }
    }
}