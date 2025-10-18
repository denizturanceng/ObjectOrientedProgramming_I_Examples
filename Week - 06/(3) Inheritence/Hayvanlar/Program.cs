using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanlar
{

    // === ÜST SINIF ===
    // Hayvan: tüm hayvanlar için ortak özellikleri barındırır.
    class Hayvan
    {
        public string Ad;
        public int Yas;
        //

        // Ortak davranış 1
        public void SolunumYap()
        {
            Console.WriteLine(Ad + " solunum yapıyor...");
        }

        // Ortak davranış 2
        public void Beslen()
        {
            Console.WriteLine(Ad + " besleniyor...");
        }

        // Ortak davranış 3
        public void Uyu()
        {
            Console.WriteLine(Ad + " uyuyor...");
        }

        // Ortak davranış 4
        public void HareketEt()
        {
            Console.WriteLine(Ad + " hareket ediyor...");
        }
    }

    // === ALT SINIF 1 ===
    // Kedi sınıfı Hayvan sınıfından kalıtım alır.
    // Kedi, tüm Hayvan metotlarını kullanabilir + kendi metotlarını ekler.
    class Kedi : Hayvan
    {
        public void Miyavla() // Kediye özel metot
        {
            Console.WriteLine(Ad + " miyavlıyor!");
        }

        public void Tirman() // Kediye özel metot
        {
            Console.WriteLine(Ad + " ağaca tırmanıyor!");
        }
    }

    // === ALT SINIF 2 ===
    // Köpek sınıfı Hayvan sınıfından kalıtım alır.
    class Kopek : Hayvan
    {
        public void Havla() // Köpeğe özel metot
        {
            Console.WriteLine(Ad + " havlıyor!");
        }

        public void IzSur() // Köpeğe özel metot, kedilerin kuyruk sallamadığı
        {
            Console.WriteLine(Ad + " iz sürüyor");
        }
    }

    // === ALT SINIF 3 ===
    // Kus sınıfı Hayvan sınıfından kalıtım alır.
    class Kus : Hayvan
    {
        public void Uc()
        {
            Console.WriteLine(Ad + " uçuyor!");
        }

        public void Ot()
        {
            Console.WriteLine(Ad + " ötüyor!");
        }
    }

    internal class Program
    {
        static void Main() // Program, Main metotunun çalışmasıyla başlar arkadaşlar.
        {
            // Kedi nesnesi
            Kedi kedi1 = new Kedi();
            kedi1.Ad = "Tekir";
            kedi1.Yas = 2;

            Console.WriteLine(kedi1.Ad+" "+ kedi1.Yas + " yaşında");
            kedi1.SolunumYap();
            kedi1.Beslen();
            kedi1.Miyavla();
            kedi1.Tirman();
            kedi1.Uyu();

            Console.WriteLine("\n--------------------------\n");

            // Köpek nesnesi
            Kopek kopek1 = new Kopek();
            kopek1.Ad = "Karabaş";
            kopek1.Yas = 3;

            Console.WriteLine(kopek1.Ad + " " + kopek1.Yas + " yaşında");
            kopek1.SolunumYap();
            kopek1.Beslen();
            kopek1.Havla();
            kopek1.IzSur();
            kopek1.Uyu();

            Console.WriteLine("\n--------------------------\n");

            // Kuş nesnesi
            Kus kus1 = new Kus();
            kus1.Ad = "Maviş";
            kus1.Yas = 1;

            Console.WriteLine(kus1.Ad + " " + kus1.Yas + " yaşında");
            kus1.SolunumYap();
            kus1.Beslen();
            kus1.Ot();
            kus1.Uc();
            kus1.Uyu();
        }
        
    }
}
