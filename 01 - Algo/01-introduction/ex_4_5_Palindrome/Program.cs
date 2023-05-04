namespace ex_4_5_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            int leftIndex;
            int rightIndex;
            bool isPalindromic;

            do
            {
                do
                {
                    Console.WriteLine("Veuillez saisir une phrase terminée par un point : ");
                    sentence = Console.ReadLine();
                    if (sentence == "" || sentence == ".")
                    {
                        Console.WriteLine("Votre phrase est VIDE !");
                    }
                }
                while (sentence == "" || sentence == ".");
                if (sentence[sentence.Length - 1] != '.')
                {
                    Console.WriteLine("Vous n'avez pas mis de POINT à la fin de votre phrase !");
                }
            }
            while (sentence[sentence.Length - 1] != '.');
            leftIndex = 0;
            rightIndex = sentence.Length - 2;
            isPalindromic = true;
            while (leftIndex < rightIndex && isPalindromic)
            {
                while (sentence[leftIndex] == ' ')
                {
                    leftIndex++;
                }
                while (sentence[rightIndex] == ' ')
                {
                    rightIndex--;
                }
                if (Char.ToLower(sentence[leftIndex]) != Char.ToLower(sentence[rightIndex]))
                {
                    isPalindromic = false;
                }
                leftIndex++;
                rightIndex--;
            }
            if (isPalindromic)
            {
                Console.WriteLine("La phrase est un palindrome");
            }
            else
            {
                Console.WriteLine("La phrase n'est pas un palindrome");
            }
        }
    }
}