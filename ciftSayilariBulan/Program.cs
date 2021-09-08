using System;

namespace ciftSayilariBulan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int bolum = 0;
            int sonuc =0;
            for (int i = 0; i <= sayi; i++)
            {
                if (((i / 2) * 2) == i)
                    sonuc = sonuc + i;
            }

            Console.WriteLine($"0 ile {sayi} arasindaki çift sayıların toplamı: {sonuc} ");
        }
    }
}
