using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitle_indeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden kitle indeksi = kilo / boy * boy
            // Beden kitle indeksi 18'e eşit veya düşükse ZAYIF
            // 18 ile 25 arasında Normalsiniz
            //25'ten büyükse Obez yazdıran program parçasını kodlayınız

            Console.Write("Kilonuzu giriniz : ");
            int kilo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Boyunuzu giriniz : ");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("Zayıfınız...");
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("Normalsiniz...");
            }
            else if (bke > 25)
            {
                Console.WriteLine("Obezsiniz...");
            }
            Console.Read();
        }
    }
}
