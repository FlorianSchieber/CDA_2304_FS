namespace ex_4_3_Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;

            const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";

            do
            {
                Console.Write("Veuillez entrer un texte d'au moins 120 caractères : ");
                text = Console.ReadLine();
            }
            while (text.Length < 120);
            for (int letter = 0; letter < ALPHABET.Length; letter++)
            {
                int occurences = 0;
                for (int index = 0; index < text.Length; index++)
                {
                    if (char.ToLower(text[index]) == ALPHABET[letter])
                    {
                        occurences++;
                    }
                }
                Console.WriteLine("La lettre " + ALPHABET[letter] + " est présente " + occurences + " fois.");
            }

        }
    }
}