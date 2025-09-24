using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfNotuHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] notlar = new int[3];
            int toplam = 0;

            for(int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine((i + 1) + ".Notu Gir:");
                notlar[i] = Convert.ToInt32(Console.ReadLine());
                if((notlar[i] <= 100) && (notlar[i] >= 0))
                {
                    toplam += notlar[i];
                }
                else {
                    Console.WriteLine("Girdiğin Aralık Yanlış. Lütfen Tekrar Dene");
                    i--;
                }
            }
            double ort = toplam / notlar.Length;
            Console.WriteLine("Not Ortalaması : " + ort);

            if(ort >= 85)
            {
                Console.WriteLine("Harf Notun: A");
            }
            else if ((ort < 85) && (ort>=70))
            {
                Console.WriteLine("Harf Notun: B");

            }
            else if ((ort < 70) && (ort >= 50))
            {
                Console.WriteLine("Harf Notun: C");
            }
            else if((ort < 50) && (ort >= 0))
            {
                Console.WriteLine("Harf Notun: F");
            }
            else
            {
                Console.WriteLine("Hatalı Ortalama");
            }
            Console.ReadLine();
            /*





                Senaryo:
                Öğrenciden 3 sınav notu alınır, 
                bu notların ortalaması hesaplanır. Ortalamaya göre A, B, C veya F harf notu 
                ekrana yazdırılır.    

                85 ve üzeri → A
                70 – 84 → B
                50 – 69 → C
                0 – 49 → F

             */

        }
    }
}
