using CL_Game421;

namespace Pj_Game421
{
    internal class Program
    {
        static void InvalidRoundsInput()
        {
            Console.WriteLine("\nSaisie incorrecte ! Le nombre de parties doit être un entier strictement positif !\n");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("PROGRAMME DE JEU DE 4-2-1\n");

            bool validInput;
            uint roundInput;

            do
            {
                do
                {
                    Console.Write("Veuillez saisir le nombre de parties que vous souhaitez jouer : ");
                    validInput = uint.TryParse(Console.ReadLine(), out roundInput);
                    if (!validInput)
                    {
                        Program.InvalidRoundsInput();
                    }
                }
                while (!validInput);

                if (roundInput <= 0)
                {
                    Program.InvalidRoundsInput();
                }

            } while (roundInput <= 0);


;
            



        }
    }
}