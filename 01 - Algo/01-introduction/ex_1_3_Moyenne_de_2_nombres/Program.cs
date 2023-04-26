namespace ex_1_3_Moyenne_de_2_nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre1;
            int nombre2;
            double moyenne;
            
            Console.WriteLine("Veuillez saisir le premier nombre : ");
            nombre1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le second nombre : ");
            nombre2 = int.Parse(Console.ReadLine());

            moyenne = (nombre1 + nombre2) / 2.0;

            Console.WriteLine("La moyenne de " + nombre1 +
                " et " + nombre2 +
                " est : " + moyenne);
        }
    }
}
