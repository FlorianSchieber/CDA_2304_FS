namespace ex_1_3_Moyenne_de_2_nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            double mean;
            
            Console.WriteLine("Veuillez saisir le premier nombre : ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le second nombre : ");
            number2 = int.Parse(Console.ReadLine());

            mean = (number1 + number2) / 2.0;

            Console.WriteLine("La moyenne de " + number1 +
                " et " + number2 +
                " est : " + mean);
        }
    }
}
