namespace _1_Pendu
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
                Console.Write("Veuillez saisir un mot de " + WORD_MIN_LENGTH + " caractères minimum : ");
                mysteryWord = Console.ReadLine();
            }
            while (mysteryWord.Length < WORD_MIN_LENGTH);

            Console.Clear();

            mysteryWord = mysteryWord.ToUpper();
            foundWord = mysteryWord.ToCharArray();
            for (int index = 1; index <= foundWord.Length - 2; index++) // Remplacement des lettres par des tirets
            {
                if (foundWord[index] != ' ')    // On ne remplace pas les espaces
                {
                    foundWord[index] = '-';
                }
            }

            int tries = START_TRIES;

            do // Description d'un tour de jeu
            {
                Console.WriteLine("Le mot mystère est : " + new string(foundWord));
                Console.WriteLine("Il vous reste " + tries + " essais.");

                do // Vérification du format de la lettre demandée
                {
                    Console.Write("Veuillez saisir une lettre : ");
                    inputLetter = Console.ReadLine();
                }
                while (inputLetter.Length != 1 || inputLetter == " ");

                letter = inputLetter.ToUpper()[0];
                letterOccurences = 0;

                for (int index = 1; index <= foundWord.Length - 2; index++) // Recherche et remplacement de la lettre dans le mot
                {
                    if (letter == mysteryWord[index])
                    {
                        foundWord[index] = letter;
                        letterOccurences++;
                    }
                }

                Console.WriteLine();

                if (letterOccurences > 0)   // La lettre est-elle présente ?
                {
                    Console.WriteLine(letter + " est présente " + letterOccurences + " fois dans le mot !");
                }
                else
                {
                    Console.WriteLine(letter + " n'est pas présente dans le mot");
                    tries--;
                }

                Console.WriteLine();
                win = true;

                for (int index = 1; index <= foundWord.Length - 2; index++) // Le mot est-il complet ?
                {
                    if (foundWord[index] == '-')
                    {
                        win = false;
                    }
                }
            }
            while (!win && tries > 0);

            if (win)
            {
                Console.WriteLine("Vous avez gagné ! Le mot mystère était : " + mysteryWord);
            }
            else
            {
                Console.WriteLine("Vous êtes pendu ! Le mot mystère était : " + mysteryWord);
            }
        }
    }
}