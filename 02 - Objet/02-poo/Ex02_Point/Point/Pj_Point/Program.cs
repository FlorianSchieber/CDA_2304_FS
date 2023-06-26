using CL_Point;

namespace Pj_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            Console.WriteLine(a);
            
            Point b = new Point(1, 2.5);
            Console.WriteLine(b);

            Console.WriteLine(b.SymmetricAboutXAxis());
            Console.WriteLine(b.SymmetricAboutYAxis());
            Console.WriteLine(b.SymmetricAboutOrigin());
            b.PermutateCoordinate();
            Console.WriteLine(b);

        }
    }
}