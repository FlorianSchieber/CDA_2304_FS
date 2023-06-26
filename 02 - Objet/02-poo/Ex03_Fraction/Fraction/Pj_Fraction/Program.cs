using CL_Fraction;

namespace Pj_Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(12, 7);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction(9);

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);

            Fraction f4 = new Fraction(11, 7);
            Fraction f5 = new Fraction(5, 4);
            Console.WriteLine(f4.IsGreaterThan(f5));

            Fraction f6 = new Fraction(22, 14);
            Console.WriteLine(f4.IsEqualTo(f6));

            Fraction fplus = f4 + f6;
            Console.WriteLine(fplus);
        }
    }
}