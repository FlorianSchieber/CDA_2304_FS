using System;

namespace ex_2_5_Ma_bicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ilFaitBeau;
            bool bicycletteFontionne;
            bool reparationsImmediates;
            bool gotAuSalon;
            bool livreDisponible;


            Console.WriteLine("J'ai envie de faire un tour en bicyclette. Fait-il beau (O/N) ?");
            ilFaitBeau = (Console.ReadLine() == "O");
            if (ilFaitBeau)
            {
                Console.WriteLine("Ma bicyclette est-elle en état de fonctionnement (O/N) ?");
                bicycletteFontionne = (Console.ReadLine() == "O");
                if (bicycletteFontionne)
                {
                    Console.WriteLine("Je fais un tour de bicyclette. The End !");
                }
                else
                {
                    Console.WriteLine("Je vais au garage.");
                    Console.WriteLine("Les réparations sont-elles immédiates (O/N) ?");
                    reparationsImmediates = (Console.ReadLine() == "O");
                    if (reparationsImmediates)
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
                gotAuSalon = (Console.ReadLine() == "O");
                if (gotAuSalon)
                {
                    Console.WriteLine("Je relis le 1er tome de GoT. The End !");
                }
                else
                {
                    Console.WriteLine("Je vais à la bibliothèqe municipale");
                    Console.WriteLine("Le livre est-il disponible ?");
                    livreDisponible = (Console.ReadLine() == "O");
                    if (livreDisponible)
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