using System;
using System.Text;

namespace soru_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            int birinciSayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            int ikinciSayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçüncü Sayıyı Giriniz: ");
            int ucuncuSayi = Convert.ToInt32(Console.ReadLine());

            if (birinciSayi > ikinciSayi)
            {
                if (ikinciSayi > ucuncuSayi)
                    Console.WriteLine($"{birinciSayi}>{ikinciSayi}>{ucuncuSayi}");
                else
                {
                    if (birinciSayi > ucuncuSayi)
                        Console.WriteLine($"{birinciSayi}>{ucuncuSayi}>{ikinciSayi}");
                    else
                        Console.WriteLine($"{ucuncuSayi}>{birinciSayi}>{ikinciSayi}");
                }

            }
            else
            {
                if (birinciSayi > ucuncuSayi)//>iki
                    Console.WriteLine($"{ikinciSayi}>{birinciSayi}>{ucuncuSayi}");
                else
                {
                    if (ucuncuSayi > ikinciSayi)
                        Console.WriteLine($"{ucuncuSayi}>{ikinciSayi}>{birinciSayi}");
                    else
                        Console.WriteLine($"{ikinciSayi}>{ucuncuSayi}>{birinciSayi}");
                }
            }

        }
    }
}
