using System;
using System.Text;

namespace stringBuilderOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            string eklenecekMetin = "selman";
            string metin = string.Format("adiniz: {0} soyadınız: {1}", "selman", "göktaş");
            string soru = eklenecekMetin;

            StringBuilder st = new StringBuilder();
            st.AppendFormat(":{0}", eklenecekMetin);
            st.Append($":{5}");
            st.Append(":C");

            
             //   metin = ":" + soru + ":5:C";
            

            Console.WriteLine(metin);

            string[] gelenDizi = st.ToString().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < gelenDizi.Length; i++)
            {
                Console.WriteLine(gelenDizi[i] + "----");
            }


            Console.ReadKey();
        }
    }
}
