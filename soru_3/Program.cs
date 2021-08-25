using System;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string renk = Console.ReadLine();

            Console.WriteLine("Ekran Rengi Uygulaması");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Ekran Rengi Uygulaması");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
        }
    }
}
