using System;

namespace Spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            while (y !=69)
            {
                Console.WriteLine("Fel! Gissa igen:");
                x = Console.ReadLine();
                y = int.Parse(x);
            }
            Console.WriteLine("Grattis! Du gissade rätt!");
            Console.ReadKey();
        }
    }
}