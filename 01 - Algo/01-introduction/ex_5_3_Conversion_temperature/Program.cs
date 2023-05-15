namespace ex_5_3_Conversion_temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dimension = 0;
            double result;
            string input;
            bool unitIsC = true;
            bool validInput;
            bool validUnit;
            bool exit = false;

            do
            {
                validInput = false;
                validUnit = false;
                Console.Write("Veuillez saisir une température entre -459.67 et 5 000 000 suivi de 'C' ou 'F' séparés par un espace ('quit' pour quitter) : ");
                input = Console.ReadLine();
                if (input == "quit")
                {
                    exit = true;
                }
                else
                {
                    if (input.Length >= 3)
                    {
                        if (input.Substring(input.Length - 2, 2) == " C")
                        {
                            unitIsC = true;
                            validUnit = true;
                        }
                        else if (input.Substring(input.Length - 2, 2) == " F")
                        {
                            unitIsC = false;
                            validUnit = true;
                        }
                        if (validUnit)
                        {
                            input = input.Substring(0, input.Length - 2);
                            if(double.TryParse(input, out dimension))
                            {
                                if (dimension >= -459.67 && dimension <= 5000000)
                                {
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Le nombre n'est pas dans la plage !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Votre saisie est incorrecte !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Votre saisie est incorrecte !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Votre saisie est incorrecte !");
                    }
                }
                if (validInput)
                {
                    if (unitIsC)
                    {
                        result = (dimension * 9 / 5) + 32;
                        Console.WriteLine(dimension + "°C = " + result + "°F");
                    }
                    else
                    {
                        result = (dimension - 32) * 5 / 9;
                        Console.WriteLine(dimension + "°F = " + result + "°C");
                    }
                }
                else if (exit)
                {
                    Console.WriteLine("Au revoir");
                }
            }
            while (!exit);
        }
    }
}
