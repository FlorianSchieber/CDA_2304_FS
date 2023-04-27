namespace ex_1_6_Inversion_2_valeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int temp;

            Console.WriteLine("Veuillez entrer un nombre A entier : ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer un nombre B entier : ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("La valeur de A est : " + A +
                " et celle de B est : " + B);

            temp = A;
            A = B;
            B = temp;

            Console.WriteLine("La valeur de A est maintenant : " + A +
                " et celle de B est : " + B);
        }
    }
}