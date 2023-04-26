namespace ex_1_4_Aire_et_Volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R;
            double aire;
            double volume;

            const double PI = Math.PI;

            Console.WriteLine("Veuillez saisir le rayon d'une sphère : ");
            R = double.Parse(Console.ReadLine());

            aire = 4 * PI * Math.Pow(R, 2);
            volume = 4 / 3.0 * PI * Math.Pow(R, 3);

            Console.WriteLine("L'aire de la sphère est : " + aire +
                " et son volume est : " + volume); 
        }
    }
}