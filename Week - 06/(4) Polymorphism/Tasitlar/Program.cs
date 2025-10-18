using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasitlar
{
    // === ÜST SINIF ===
    // "Tasit" sınıfı tüm araçların ortak özelliklerini barındırır.
    // Her aracın bir "Marka" bilgisi vardır ve hepsi bir şekilde "HareketEt()" metoduna sahiptir.
    // Ancak hareket etme biçimi her araçta farklıdır — işte bu polimorfizm!
    class Tasit
    {
        public string Marka; // Her taşıtın bir markası vardır.

        // "virtual" anahtar kelimesi: Bu metodun alt sınıflarda yeniden yazılabileceğini (override edilebileceğini) belirtir.
        public virtual void HareketEt()
        {
            Console.WriteLine(Marka + " yavaşça ilerliyor... (Genel taşıt davranışı)");
        }

        // Ortak bir metot (virtual olmayan)
        // Bu metot alt sınıflarda aynı şekilde çalışır, değiştirilemez.
        public void Dur()
        {
            Console.WriteLine(Marka + " durdu.");
        }
    }

    // === ALT SINIF 1 ===
    // "Araba" sınıfı "Tasit" sınıfından kalıtım alır.
    // Araba da bir taşıttır ama hareket etme biçimi farklıdır.
    class Araba : Tasit
    {
        // "override" ile üst sınıftaki HareketEt() metodunu yeniden tanımlarız.
        public override void HareketEt()
        {
            Console.WriteLine(Marka + " karayolunda tekerlekleriyle ilerliyor.");
        }

        // Araba’ya özgü ek bir metot
        public void KlimaAc()
        {
            Console.WriteLine(Marka + " klimasını açtı.");
        }
    }

    // === ALT SINIF 2 ===
    // "Ucak" sınıfı da "Tasit" sınıfından kalıtım alır.
    class Ucak : Tasit
    {
        // Uçakların hareket etme biçimi diğer taşıtlardan tamamen farklıdır.
        public override void HareketEt()
        {
            Console.WriteLine(Marka + " havalanıyor ve gökyüzünde süzülüyor.");
        }

        // Uçağa özel metot
        public void InisYap()
        {
            Console.WriteLine(Marka + " piste iniş yapıyor.");
        }
    }

    // === ALT SINIF 3 ===
    // "Gemi" sınıfı da "Tasit" sınıfından kalıtım alır.
    class Gemi : Tasit
    {
        public override void HareketEt()
        {
            Console.WriteLine(Marka + " denizde dalgalar arasında ilerliyor.");
        }

        // Gemiye özgü metot
        public void DemirAt()
        {
            Console.WriteLine(Marka + " limanda demir attı.");
        }
    }

    // === PROGRAM BAŞLANGICI ===
    class Program
    {
        static void Main()
        {
            // Burada polimorfizmi gösterebilmek için "Tasit" türünde bir dizi oluşturuyoruz.
            // Aynı türden (Tasit) referans, farklı alt sınıf nesnelerine bağlanabiliyor.
            Tasit[] araclar = new Tasit[3];

            // Her eleman aslında farklı bir alt sınıf nesnesi.
            araclar[0] = new Araba();
            araclar[0].Marka = "Toyota";

            araclar[1] = new Ucak();
            araclar[1].Marka = "Airbus";

            araclar[2] = new Gemi();
            araclar[2].Marka = "Titanic";

            Console.WriteLine("=== ARAÇLARIN HAREKET BİÇİMLERİ ===\n");

            // Polimorfizm burada gerçekleşiyor:
            // Aynı metot adı (HareketEt) çağrılıyor ama her sınıf farklı davranış gösteriyor.
            foreach (Tasit t in araclar)
            {
                t.HareketEt(); // Alt sınıfa göre farklı çıktı verir.
            }

            Console.WriteLine("\n=== HER ARAÇ İÇİN ÖZEL DAVRANIŞLAR ===\n");

            // Her nesnenin kendi türüne özel metotları burada çağrılıyor.
            // (Araba), (Ucak), (Gemi) dönüşümleri sayesinde
            // Tasit türündeki referansları gerçek türlerine dönüştürüp özel metotlara erişiyoruz.

            Araba araba1 = (Araba)araclar[0]; // araclar[0] aslında bir Araba nesnesi, bu yüzden Araba türüne dönüştürdük.
            Console.WriteLine("\n" + araba1.Marka + " özel davranışı:");
            araba1.KlimaAc(); // Artık sadece Araba sınıfına ait metodu kullanabiliyoruz.
            araba1.Dur();

            Ucak ucak1 = (Ucak)araclar[1]; // araclar[1] aslında bir Ucak nesnesi, bu yüzden Ucak türüne dönüştürdük.
            Console.WriteLine("\n" + ucak1.Marka + " özel davranışı:");
            ucak1.InisYap(); // Ucak sınıfına özel metot
            ucak1.Dur();

            Gemi gemi1 = (Gemi)araclar[2]; // araclar[2] aslında bir Gemi nesnesi, bu yüzden Gemi türüne dönüştürdük.
            Console.WriteLine("\n" + gemi1.Marka + " özel davranışı:");
            gemi1.DemirAt(); // Gemi sınıfına özel metot
            gemi1.Dur();

            Console.WriteLine("\nProgram sona erdi.");
        }
    }
}
