namespace ex_5_1_Parfaits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit;
            int perfectNumberCount;
            int perfectNumber;

            Console.Write("Veuillez saisir la limite de calcul : ");
            limit = int.Parse(Console.ReadLine());
            perfectNumberCount = 1;
            perfectNumber = 1;
            while (perfectNumberCount <= limit)
            {
                int divisorSum = 0;
                for (int divisor = 1; divisor < perfectNumber; divisor++)
                {
                    if (perfectNumber % divisor == 0)
                    {
                        divisorSum += divisor;
                    }
                }
                if (perfectNumber == divisorSum)
                {
                    Console.WriteLine(perfectNumber + " est un nombre parfait.");
                    perfectNumberCount++;
                }
                perfectNumber++;
            }

        }
    }
}