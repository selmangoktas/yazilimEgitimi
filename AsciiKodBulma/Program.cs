using System;

namespace AsciiKodBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ascii Kodunu Öğrenmek istediğiniz Karakteri giriniz :");
            string metin = Console.ReadLine();
            int asci = 0;
            string asciSonuc = string.Empty;

           
                
                foreach (char c in metin+"")
                {
                    asci = (int)c;
                }
           
           
            Console.WriteLine("Ascii Kodu :"+asci);
        }
    }
}
