using System;

namespace terstenYazanUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı Giriniz: ");
            string sayi =Console.ReadLine();

            for (int i = sayi.Length-1; i >= 0; i--)
            {
                Console.Write(sayi[i]);
            }
        }
    }
}
