namespace ex_3_6_Fourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int secretNumber;
            int minFork;
            int maxFork;
            int trials;
            bool found;

            const int MIN_START = 0;
            const int MAX_START = 100;

            Random random = new Random();

            secretNumber = random.Next(MIN_START, MAX_START + 1);
            minFork = MIN_START;
            maxFork = MAX_START;
            trials = 0;
            found = false;
            while (!found)
            {
                do
                {
                    Console.Write("Veuillez saisir un nombre entre " + minFork + " et " + maxFork + " : ");
                    input = int.Parse(Console.ReadLine());
                }
                while (input < minFork || input > maxFork);
                trials++;
                if (input < secretNumber)
                {
                    Console.WriteLine("Trop petit !");
                    minFork = input + 1;
                }
                else if (input > secretNumber)
                {
                    Console.WriteLine("Trop grand !");
                    maxFork = input - 1;
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé en " + trials + " essais.");
                    found = true;
                }
            }
        }
    }
}