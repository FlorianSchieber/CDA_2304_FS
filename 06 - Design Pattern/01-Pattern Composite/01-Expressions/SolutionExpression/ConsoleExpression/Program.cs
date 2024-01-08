using CL_Expression;

internal class Program
{
    private static void Main(string[] args)
    {
        Expression exp1 = new Addition(new Number(1), new Number(2));

        Console.WriteLine(exp1.Format());

        Expression exp2 = new Addition(exp1, new Number(3));

        Console.WriteLine(exp2.Format());

        Expression exp3 = new Substraction(exp1, exp2);

        Console.WriteLine(exp3.Format());

        Expression exp4 = new Substraction(new Number(2), new Number(1));

        Console.WriteLine(exp4.Format());
    }
}