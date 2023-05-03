namespace ex_3_7_Barnabé
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startSoldEuro;
            int remainingSoldCent;
            int shops;

            Console.Write("De combien d'argent dispose Barnabé ? : ");
            startSoldEuro = double.Parse(Console.ReadLine());
            remainingSoldCent = (int)(startSoldEuro * 100);
            shops = 0;
            while (remainingSoldCent > 0)
            {
                if (remainingSoldCent < 200)
                {
                    remainingSoldCent = 0;
                }
                else
                {
                    remainingSoldCent = remainingSoldCent / 2 - 100;
                }
                shops++;
            }
            Console.Write("Barnabé a acheté dans " + shops + " magasin(s).");
        }
    }
}