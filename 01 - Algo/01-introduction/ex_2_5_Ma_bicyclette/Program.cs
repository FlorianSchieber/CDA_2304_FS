using System;

namespace ex_2_5_Ma_bicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool niceWeather;
            bool bicycleWorks;
            bool immediateRepairs;
            bool gotLivingRoom;
            bool bookAvailable;


            Console.WriteLine("J'ai envie de faire un tour en bicyclette. Fait-il beau (O/N) ?");
            niceWeather = (Console.ReadLine() == "O");
            if (niceWeather)
            {
                Console.WriteLine("Ma bicyclette est-elle en état de fonctionnement (O/N) ?");
                bicycleWorks = (Console.ReadLine() == "O");
                if (bicycleWorks)
                {
                    Console.WriteLine("Je fais un tour de bicyclette. The End !");
                }
                else
                {
                    Console.WriteLine("Je vais au garage.");
                    Console.WriteLine("Les réparations sont-elles immédiates (O/N) ?");
                    immediateRepairs = (Console.ReadLine() == "O");
                    if (immediateRepairs)
                    {
                        Console.WriteLine("Je fais un tour de bicyclette. The End !");
                    }
                    else
                    {
                        Console.WriteLine("Tant pis, je vais à pied jusqu’à l’étang pour cueillir les joncs. The End !");
                    }
                }

            }
            else
            {
                Console.WriteLine("Tant pis, je vais consacrer ma journée à la lecture.");
                Console.WriteLine("Le 1er tome de GoT est-il dans la bibliothèque du salon ?");
                gotLivingRoom = (Console.ReadLine() == "O");
                if (gotLivingRoom)
                {
                    Console.WriteLine("Je relis le 1er tome de GoT. The End !");
                }
                else
                {
                    Console.WriteLine("Je vais à la bibliothèqe municipale");
                    Console.WriteLine("Le livre est-il disponible ?");
                    bookAvailable = (Console.ReadLine() == "O");
                    if (bookAvailable)
                    {
                        Console.WriteLine("Je rentre à la maison et je lis le 1er tome de GoT. The End !");
                    }
                    else
                    {
                        Console.WriteLine("J'emprunte un roman policier");
                        Console.WriteLine("Je rentre à la maison et je lis ce livre. The End !");
                    }
                }
            }

        }
    }
}