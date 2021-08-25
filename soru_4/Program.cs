using System;

namespace soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Karakter Giriniz");
            char tus = Console.ReadKey().KeyChar;
            int ascii = (int)tus;
            Console.WriteLine("Klavyeden Girilen deger : {0} ---- Ascii karşılığı {1}", tus, ascii);
            Console.ReadKey();
        }
    }
}
