using System;

namespace soru_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz.");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 0)
                sayi = -sayi;

            Console.WriteLine($"{sayi} 'sının mutlak degeri : |{sayi}| dir.");
        }
    }
}
