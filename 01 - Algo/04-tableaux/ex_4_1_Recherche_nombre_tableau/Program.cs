namespace ex_4_1_Recherche_nombre_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int index;
            bool found;

            int[] LIST = { 8, 16, 32, 64, 128, 256, 512 };

            Console.Write("Veuillez entrer un nombre : ");
            N = int.Parse(Console.ReadLine());
            found = false;
            index = 0;
            while (!found && index < LIST.Length)
            {
                if (LIST[index] == N)
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            }
            if (found)
            {
                Console.WriteLine("Nombre trouvé en indice : " + index);
            }
            else
            {
                Console.WriteLine("Nombre non trouvé");
            }

        }
    }
}