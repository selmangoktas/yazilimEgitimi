using System;

namespace soru_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notunuzu giriniz: ");
            double not = Convert.ToDouble(Console.ReadLine());
            //0-20   0 
            //21-44  1
            //45-55  2
            //55-70  3
            //70-85  4
            //85-100 5

            if (not < 20)
                Console.WriteLine("Not Karşılığı :0");
            else if (not < 45)
                Console.WriteLine("Not Karşılığı :1");
            else if (not < 55)
                Console.WriteLine("Not Karşılığı :2");
            else if (not < 70)
                Console.WriteLine("Not Karşılığı :3");
            else if (not < 85)
                Console.WriteLine("Not Karşılığı :4");
            else if (not < 100)
                Console.WriteLine("Not Karşılığı :5");

           
        }
    }
}
