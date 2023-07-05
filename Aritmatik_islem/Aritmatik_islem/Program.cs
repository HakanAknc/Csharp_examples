using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmatik_islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, toplam, carpim, bolum, fark;

            Console.WriteLine("***** Aritmetik İşlem *****");
            Console.WriteLine();
            s1 = 20;
            s2 = 5;
            toplam = s1 + s2;
            fark = s1 - s2;
            carpim = s1 * s2;
            bolum = s1 / s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine();
            Console.WriteLine("***** Aritmetik İşlem *****");

            Console.Read();
        }
    }
}
