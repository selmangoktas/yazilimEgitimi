﻿using System;

namespace asalSayiBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    kontrol++;
            }

            if (kontrol != 0)
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            else
                Console.WriteLine("Girdiğiniz sayı asaldır.");
            Console.ReadKey();
        }
    }
}
