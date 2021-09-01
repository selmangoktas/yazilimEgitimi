using System;

namespace soru_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı Adını Giriniz:");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Parolanızı Giriniz:");
            string parola = Console.ReadLine();

            if (kullaniciAdi == "admin" && parola == "12345")
                Console.WriteLine("Giriş Başarılı Yönlendiriliyorsunuz.");
            else
                Console.WriteLine("Yanlış bir parola yada şifre girdiniz");
        }
    }
}
