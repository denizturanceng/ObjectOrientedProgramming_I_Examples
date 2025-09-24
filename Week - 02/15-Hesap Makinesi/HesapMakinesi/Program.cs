using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("**MENU**");
                Console.WriteLine("\n1.Toplama");
                Console.WriteLine("\n2.Çıkarma");
                Console.WriteLine("\n3.Çarpma");
                Console.WriteLine("\n4.Bölme");
                Console.WriteLine("\n0.Çıkış");

                Console.WriteLine("Seçim: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 0) break;

                if ((secim > 4) || secim < 0) continue;

                Console.Write("Lütfen ilk sayıyı giriniz:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lütfen ikinci sayıyı giriniz:");
                int y = Convert.ToInt32(Console.ReadLine());

                switch(secim)
                {
                    case 1: // Toplama İşlemi
                        Console.WriteLine("Sonuç:" + ( x + y));
                        break;
                    case 2:
                        Console.WriteLine("Sonuç:" + (x - y));
                        break;
                    case 3:
                        Console.WriteLine("Sonuç:" + (x * y));
                        break;
                    case 4:
                        if (y != 0)
                        {
                            Console.WriteLine("Sonuç:" + (x / y));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("bölen 0 olamaz.");
                            break;
                        }          
                }

            }
            
        }
    }
}
