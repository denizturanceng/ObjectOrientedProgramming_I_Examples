using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapSayaci
{
    // Bu örnek "static değişkenler" ve "static metotlar" konusunu göstermek için hazırlanmıştır.
    // Konuyu daha somut hale getirmek için bir "Kitap" sınıfı tanımlıyoruz.
    // Her yeni kitap nesnesi oluşturulduğunda, toplam kitap sayısını takip eden static bir sayaç artacak.

    class Kitap
    {
        // === Instance (nesneye ait) değişken ===
        // "Ad" değişkeni her kitap nesnesi için farklı olabilir.
        // Örneğin, bir kitabın adı "Suç ve Ceza" iken diğerininki "Sefiller" olabilir.
        public string Ad;

        // === Static (sınıfa ait) değişken ===
        // Bu değişken tüm kitap nesneleri tarafından paylaşılır.
        // Yani bellekte yalnızca 1 tane "ToplamKitapSayisi" vardır.
        // Her yeni kitap oluşturulduğunda, bu sayı 1 artacak.
        public static int ToplamKitapSayisi = 0;

        // === Constructor (Yapıcı Metot) ===
        // Constructor, bir sınıftan nesne oluşturulduğunda otomatik olarak çalışan özel bir metottur.
        // "Kitap" sınıfının constructor'ı iki görev yapar:
        // 1. Oluşturulan kitabın adını "Ad" değişkenine atar.
        // 2. Static sayacı 1 artırarak toplam kitap sayısını günceller.
        public Kitap(string ad)
        {
            Ad = ad;                // Nesneye özel değişkenin değerini atadık.
            ToplamKitapSayisi++;    // Static değişkenin değeri her nesne oluştuğunda artar.
        }

        // === Instance (normal) metot ===
        // Bu metot sadece bir kitabın kendi bilgisini (örneğin adını) ekrana yazdırır.
        // Dikkat: Static değildir, çünkü her nesne kendi adına sahiptir.
        public void BilgiYazdir()
        {
            Console.WriteLine("Eklenmiş Kitap: "+Ad);
        }

        // === Static metot ===
        // Static metotlar sınıfa aittir, nesneye değil.
        // Bu metodu çağırmak için herhangi bir "Kitap" nesnesi oluşturmak gerekmez.
        // Örneğin: Kitap.SayaciYazdir();
        // Bu metot static olduğu için, yalnızca static değişkenleri kullanabilir (ToplamKitapSayisi gibi).
        public static void SayaciYazdir()
        {
            Console.WriteLine("\nŞu ana kadar oluşturulan toplam kitap sayısı: " + ToplamKitapSayisi);
        }
    }

    // Programın başlangıç noktası
    internal class Program
    {
        static void Main()
        {
            // === Nesne oluşturma ===
            // Burada 7 farklı kitap nesnesi oluşturuyoruz.
            // Her new Kitap(...) çağrısı constructor'ı tetikler ve static sayaç 1 artar.
            // Böylece toplam kitap sayısı 7 olacaktır.
            Kitap k1 = new Kitap("Harry Potter ve Felsefe Taşı");
            Kitap k2 = new Kitap("Harry Potter ve Sırlar Odası");
            Kitap k3 = new Kitap("Harry Potter ve Azkaban Tutsağı");
            Kitap k4 = new Kitap("Harry Potter ve Ateş Kadehi");
            Kitap k5 = new Kitap("Harry Potter ve Zümrüdüanka Yoldaşlığı");
            Kitap k6 = new Kitap("Harry Potter ve Melez Prens");
            Kitap k7 = new Kitap("Harry Potter ve Ölüm Yadigarları");

            // === Normal metot çağrıları ===
            // Her kitap nesnesinin kendi "BilgiYazdir()" metodunu çağırıyoruz.
            // Bu metot static değildir, çünkü her nesnenin farklı "Ad" değeri vardır.
            // Instance (örnek) metotlar nesne üzerinden çağrılır: nesneAdi.MetotAdi()
            k1.BilgiYazdir();
            k2.BilgiYazdir();
            k3.BilgiYazdir();
            k4.BilgiYazdir();
            k5.BilgiYazdir();
            k6.BilgiYazdir();
            k7.BilgiYazdir();

            // === Static metot çağrısı ===
            // Static metotlar nesneye değil sınıfa aittir.
            // Bu yüzden nesne oluşturmadan doğrudan sınıf adı üzerinden çağrılır.
            // Örneğin: Kitap.SayaciYazdir();
            // Bu metot static olduğu için tüm kitapların ortak sayacına erişir.
            Kitap.SayaciYazdir();

            // Program bittiğinde static değişken hâlâ bellekte 7 değerini tutar.
            // Çünkü static değişkenler, program kapanana kadar varlığını sürdürür.
        }
    }
}
