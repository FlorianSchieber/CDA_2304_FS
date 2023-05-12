namespace ex_5_2_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dimension = 0;
            string input;
            bool unitIsKm = true;
            bool validInput = false;
            bool exit = false;

            const double MI_IN_KM = 1.609;

            do
            {
                Console.Write("Veuillez saisir un nombre entre 0.01 et 1 000 000 à convertir (éventuellement suivi d'une unité [km/mi]) : ");
                input = Console.ReadLine();
                if (input == "q")
                {
                    exit = true;
                }
                else
                {
                    unitIsKm = true;
                    if (input.Length >= 2)
                    {
                        
                        if (input.Substring(input.Length -2, 2).ToLower() == "km")
                        {
                            input = input.Substring(0, input.Length - 2);
                        }
                        else if (input.Substring(input.Length - 2, 2).ToLower() == "mi")
                        {
                            unitIsKm  = false;
                            input = input.Substring(0, input.Length - 2);
                        }
                    }
                    if (double.TryParse(input, out dimension))
                    {
                        if (dimension <= 1000000 && dimension >= 0.01)
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
            }
            while (!(validInput || exit));
            if (validInput) { 
                if (unitIsKm)
                {
                    Console.WriteLine(dimension + " kilomètre(s) = " + dimension / MI_IN_KM + " mile(s)");
                }
                else
                {
                    Console.WriteLine(dimension + " mile(s) = " + dimension * MI_IN_KM + " kilomètre(s)");
                }
            }
            else if (exit)
            {
                Console.WriteLine("Au revoir !");
            }
        }
    }
}