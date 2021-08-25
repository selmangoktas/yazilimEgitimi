using System;

namespace soru_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize Notunuzu Giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final Notunuzu Giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());


            //double sonuc = vize * (40 / 100) + final * (60 / 100);
            double sonuc = vize * 0.4 + final * 0.6;

            if (vize <= 100 || final <= 100)
            {
                if (sonuc >= 50)
                {
                    Console.WriteLine("GEÇTİNİZ");
                }
                else 
                    Console.WriteLine("KALDINIZ");
            }
            else
            {
                Console.WriteLine("100 den büyük not girilemez");
            }

        }
    }
}
