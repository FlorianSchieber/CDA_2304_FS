internal class Program
{
    private static void Main(string[] args)
    {
        const string NEXT = "go";

        string inputName;
        double inputPrice;
        List<string> vegetablesNames = new List<string>();
        List<double> vegetablesPrices = new List<double>();
        

        do
        {
            Console.Write("Veuillez saisir un légume ('go' pour la suite) : ");
            inputName = Console.ReadLine();
            if (inputName != NEXT)
            {
                vegetablesNames.Add(inputName);
                Console.Write("Veuillez saisir le prix au kilo : ");
                inputPrice = double.Parse(Console.ReadLine());
                vegetablesPrices.Add(inputPrice);
            }
        }
        while (inputName != NEXT);
        int indexMin = 0;
        for (int index = 0; index < vegetablesNames.Count; index++)
        {
            Console.WriteLine("1 kilogramme de " + vegetablesNames[index] + " coûte " + vegetablesPrices[index] + " euros.");
            if (vegetablesPrices[index] < vegetablesPrices[indexMin])
            {
                indexMin = index;
            }
        }
        Console.WriteLine("Légume le moins cher au kilo : " + vegetablesNames[indexMin]);
    }
}