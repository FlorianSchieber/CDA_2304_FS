namespace ex_7_Pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mysteryWord;
            char[] foundWord;
            
            string inputLetter;
            char letter;
            int letterOccurences;
            bool win;

            const int WORD_MIN_LENGTH = 5;
            const int START_TRIES = 6;

            do // Vérification de la saisie du mot mystère
            {
                Console.Write("Veuillez saisir un mot : ");
                mysteryWord = Console.ReadLine();
            }
            while (mysteryWord.Length < WORD_MIN_LENGTH);

            Console.Clear();

            foundWord = mysteryWord.ToCharArray();  
            for (int index = 1; index <= foundWord.Length; index++) // Remplacement des lettres par des tirets
            {
                if (foundWord[index] != ' ')    // On ne remplace pas les espaces
                {
                    foundWord[index] = '-';
                }
            }

            int tries = START_TRIES;

            do // Description d'un tour de jeu
            {
                Console.WriteLine("Le mot mystère est :" + foundWord);
                Console.WriteLine("Il vous reste " + tries + " essais.\n");

                do // Vérification du format de la lettre demandée
                {
                    Console.WriteL
                }
            } 
            while ()

        }
    }
}