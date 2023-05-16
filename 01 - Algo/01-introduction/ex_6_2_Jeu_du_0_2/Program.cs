namespace ex_6_2_Jeu_du_0_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerChoice;
            int computerChoice;
            int playerPoints = 0;
            int computerPoints = 0;
            bool stopGame = false;

            const int POINTS_TO_WIN = 10;

            Random rand = new Random();

            do
            {
                Console.Write("Veuillez saisir un nombre entre 0 et 2 (nombre négatif pour quitter le jeu) : ");
                playerChoice = int.Parse(Console.ReadLine());
                computerChoice = rand.Next(0, 3);
                if (playerChoice < 0)
                {
                    stopGame = true;
                }
                else if (playerChoice <= 2)
                {
                    if (playerChoice == computerChoice + 2 || playerChoice == computerChoice - 1)
                    {
                        playerPoints++;
                    }
                    else if (playerChoice == computerChoice - 2 || playerChoice == computerChoice + 1)
                    {
                        computerPoints++;
                    }
                    Console.WriteLine("Votre choix : " + playerChoice + ", votre adversaire : " + computerChoice);
                    Console.WriteLine("Votre score : " + playerPoints + ", votre adversaire : " + computerPoints);
                }
            }
            while (playerPoints < POINTS_TO_WIN
                    && computerPoints < POINTS_TO_WIN
                    && !stopGame);
            if (stopGame)
            {
                Console.WriteLine("Au revoir !");
            }
            else
            {
                if (playerPoints >= POINTS_TO_WIN)
                {
                    Console.WriteLine("Vous avez gagné !");
                }
                else if (computerPoints >= POINTS_TO_WIN)
                {
                    Console.WriteLine("Vous avez perdu...");
                }
            }
        }
    }
}