using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenFazla_if_blogu_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, ort;

            Console.Write("Sınav 1 = ");
            s1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Sınav 1 = ");
            s2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Sınav 3 = ");
            s3 = Convert.ToInt16(Console.ReadLine());

            ort = (s1 + s2 + s3) / 3;
            Console.Write("Ortalamanız = " + ort);

            //Console.Read();

            if (ort <= 49)
            {
                Console.Write(" -- Durum: Vasat    :( ");
            }
            if (ort >= 50 & ort <= 65)
            {
                Console.Write(" -- Durum: Orta     :/ ");
            }
            if (ort >= 66 & ort <= 75)
            {
                Console.Write(" -- Durum: Eh işte  :| ");
            }
            if (ort >= 76 & ort <= 85)
            {
                Console.Write(" -- Durum: İyi      :) ");
            }
            if (ort >= 86 & ort <= 100)
            {
                Console.Write(" -- Durum: Çok iyi  :)  :)");
            }

            Console.Read();
        }
    }
}
