using System;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dogum yılınızı giriniz:");
            int DogumYiliniz = Convert.ToInt32(Console.ReadLine());

            int yas = 0;

            int bugunkuYil = 2020;
            //Convert.ToInt32(DateTime.Now.Year);

            yas = bugunkuYil - DogumYiliniz;
            Console.WriteLine($"Bugün yaşınız: {yas}");

        }
    }
}
