using System;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kebab-case;
            //string camelCase;
            //string UpperCase; //Pascal case

            Console.WriteLine("Adınızı Giriniz");
            string ad = string.Empty;
            ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz");
            string soyad = string.Empty;
            soyad = Console.ReadLine();

            string adSoyad = "";

             
            //Console.WriteLine("Adınız: "+ad+" Soyadınız: "+soyad);


            /*adSoyad = ad + " " + soyad;
            Console.WriteLine("Adınız Soyadınız: "+adSoyad);*/


            //Console.WriteLine("Adınız Soyadınız: {1} {0}", ad, soyad);

            Console.WriteLine($"ad:{ad} soyad:{soyad}");



        }
    }
}
