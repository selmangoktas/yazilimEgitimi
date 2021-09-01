using System;

namespace soru_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            int birinciSayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            int ikinciSayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"birinci sayı {ikinciSayi} ikinci sayı {birinciSayi} ");
        }
    }
}
