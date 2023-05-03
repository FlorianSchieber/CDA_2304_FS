namespace ex_4_4_Tri_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 128, 64, 8, 512, 16, 32, 256 };
            int temp;
            int indexMin;
            int min;

            // PROCESS

            for (int i = 0; i < list.Length - 1; i++)
            {
                indexMin = i;
                min = list[i];
                for (int j = i; j < list.Length; j++)
                {
                    if (list[j] < min)
                    {
                        indexMin = j;
                        min = list[j];
                    }
                }
                if (indexMin != i)
                {
                    temp = list[i];
                    list[i] = list[indexMin];
                    list[indexMin] = temp;
                }
            }

            // DISPLAY

            for (int k = 0; k < list.Length; k++)
            {
                Console.WriteLine(list[k]);
            }
            
        }
    }
}