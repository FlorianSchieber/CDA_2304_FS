namespace ex_6_3_Calcul_nombre_personnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int youngs = 0;

            const int OLD_AGE = 20;
            const int PEOPLE = 20;

            int[] ages = new int[PEOPLE];

            for (int person = 0; person < PEOPLE; person++)
            {
                Console.WriteLine("Veuillez entrer l'âge de la personne n°" + (person + 1));
                ages[person] = int.Parse(Console.ReadLine());
                if (ages[person] < OLD_AGE)
                {
                    youngs++;
                }
            }
            if (youngs == 0)
            {
                Console.WriteLine("Toutes les personnes ont moins de " + OLD_AGE + " ans.");
            }
            else if (youngs == PEOPLE)
            {
                Console.WriteLine("Toutes les personnes ont " + OLD_AGE + " ans ou plus.");
            }
            else
            {
                Console.WriteLine("Il y a " + youngs + " personnes de moins de " + OLD_AGE + " ans, et " + (PEOPLE - youngs) + " autres personnes.");
            }
        }
    }
}