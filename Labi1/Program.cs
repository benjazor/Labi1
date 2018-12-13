using System;

namespace Labi1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome to the map generator!\nEnter a size for the map: ");
            Map Game = new Map(int.Parse(Console.ReadLine()));
            Game.Start();

            while (true)
            {
                Console.Clear();
                Game.Print();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nCommands:\t\tActions:\t");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t0\t-->\t Generate more\t");
                Console.WriteLine("\t1\t-->\t Reset map\t");
                Console.WriteLine("\t2\t-->\t Exit\t\t");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write("Enter action here: ");
                Console.BackgroundColor = ConsoleColor.Black;

                switch (Console.ReadLine())
                {
                    case "0":
                        Game.Generate();
                        break;
                    case "1":
                        Game.Reset();
                        Game.Start();
                        break;
                    case "2":
                        return;
                    default:
                        continue;
                }

            }

            /*
            while (Console.ReadLine() != "exit")
            {
                testmap.GenerateStart();
                Console.WriteLine(testmap);
            }
            */

            Console.ReadLine();
        }
    }
}
