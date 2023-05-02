namespace ex_4_2_Recherche_lettre_phrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter;
            int occurences;

            const string SENTENCE = "Bonjour je m'appelle Florian.";

            if (SENTENCE == "." || SENTENCE == "")
            {
                Console.Write("LA CHAINE EST VIDE");
            }
            else
            {
                do
                {
                    Console.Write("Veuillez entrer une lettre : ");
                    letter = Console.ReadLine();
                }
                while (letter.Length != 1);
                occurences = 0;
                for (int index = 0; index < SENTENCE.Length; index++)
                {
                    if (SENTENCE[index].ToString() == letter)
                    {
                        occurences++;
                    }
                }
                if (occurences ==0)
                {
                    Console.Write("La lettre " + letter + " n'est pas présente");
                }
                else
                {
                    Console.Write("La lettre " + letter + " est présente " + occurences + " fois");
                }
            }
        }
    }
}