namespace ex_6_4_Denombrer_alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string VOWELS = "aeiouy";
            const string CONSONANTS = "bcdfghjklmnpqrstvwxz";
            const string DIGITS = "0123456789";

            string text;
            int vowelsCount = 0;
            int consonantsCount = 0;
            int digitsCount = 0;
            int digitsSum = 0;

            Console.WriteLine("Veuillez saisir un texte : ");
            text = Console.ReadLine();
            
            foreach (char textChar in text)
            {
                foreach (char searchChar in VOWELS)
                {
                    if (char.ToLower(textChar) == searchChar)
                    {
                        vowelsCount++;
                    }
                }
                foreach (char searchChar in CONSONANTS)
                {
                    if (char.ToLower(textChar) == searchChar)
                    {
                        consonantsCount++;
                    }
                }
                foreach (char searchChar in DIGITS)
                {
                    if (textChar == searchChar)
                    {
                        digitsCount++;
                        digitsSum += int.Parse(searchChar.ToString());  // Conversion de searchChar en chaîne, puis en entier
                    }
                }
            }
            double digitMean;
            if (digitsCount == 0)
            {
                digitMean = 0;
            }
            else
            {
                digitMean = (double)digitsSum / digitsCount;
            }
            Console.WriteLine("Il y a " + vowelsCount + " voyelles.");
            Console.WriteLine("Il y a " + consonantsCount + " consonnes.");
            Console.WriteLine("Il y a " + digitsCount + " chiffres.");
            Console.WriteLine("La moyenne des chiffres est de " + Math.Round(digitMean, 2));

        }
    }
}