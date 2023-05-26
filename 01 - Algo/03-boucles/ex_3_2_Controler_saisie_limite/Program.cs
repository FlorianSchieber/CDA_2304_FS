namespace ex_3_2_Controler_saisie_limite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int trials;
            bool isConnected;

            const string PASSWORD = "formation";
            const int MAXIMUM_TRIES = 3;

            trials = MAXIMUM_TRIES;
            isConnected = false;

            do
            {
                Console.WriteLine("Veuillez saisir votre mot de passe : ");
                input = Console.ReadLine();
                if (input == PASSWORD)
                {
                    isConnected = true;
                }
                else
                {
                    trials--;
                }
            }
            while (trials > 0 && !isConnected);
            if (isConnected)
            {
                Console.WriteLine("Vous êtes connecté");
            }
            else
            {
                Console.WriteLine("Votre compte est bloqué");
            }
        }
    }
}
