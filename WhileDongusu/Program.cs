using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi!=0)
            {
                Console.WriteLine("Lütfen yeni bir sayı giriniz.");
                sayi = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("0 girildiği için döngü bitirildi.");
            Console.ReadKey();
        }
    }
}
