using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketKasa // Programın ait olduğu isim alanı (namespace)
{
    // Ürünleri temsil eden bir veri yapısı (struct)
    public struct Urun
    {
        public string Ad;    // Ürünün adı
        public double Fiyat; // Ürünün fiyatı

        // Ürün bilgisini ekrana yazdırmak için kullanılan metot
        public void BilgiYazdir(int sira)
        {
            // Örnek çıktı: "1. Ekmek - 5 TL"
            Console.WriteLine(sira + ". " + Ad + " - " + Fiyat + " TL");
        }
    }

    internal class Program // Programın ana sınıfı
    {
        static void Main(string[] args) // Programın başlangıç noktası
        {
            // 5 elemanlı bir ürün dizisi oluşturuluyor
            Urun[] urunler = new Urun[5];

            // Her ürünün adı ve fiyatı tek tek atanıyor
            urunler[0].Ad = "Ekmek"; 
            urunler[0].Fiyat = 5.0;
            urunler[1].Ad = "Süt"; 
            urunler[1].Fiyat = 15.0;
            urunler[2].Ad = "Yumurta"; 
            urunler[2].Fiyat = 3.5;
            urunler[3].Ad = "Makarna"; 
            urunler[3].Fiyat = 12.0;
            urunler[4].Ad = "Elma"; 
            urunler[4].Fiyat = 10.0;

            double toplam = 0;   // Alışveriş boyunca birikecek toplam tutar
            bool devam = true;   // While döngüsünü kontrol eden bayrak (flag) değişkeni

            // Başlık ve ürün listesinin ekrana yazdırılması
            Console.WriteLine("=== MARKET KASASI ===");
            Console.WriteLine("Ürün Listesi:");

            // Ürün listesini ekrana sırayla yazdırmak için for döngüsü
            for (int i = 0; i < urunler.Length; i++)
            {
                // Her ürün struct’ındaki BilgiYazdir() metodu çağrılıyor
                urunler[i].BilgiYazdir(i + 1);
            }

            // Kullanıcı ürün seçtiği sürece çalışacak döngü
            while (devam) // devam değişkeni true olduğu sürece burada while döngüsü çalışır.
            {
                // Kullanıcıdan ürün numarası istenir
                Console.Write("\nÜrün numarasını giriniz (1–5) veya 0 ile kasaya geçiniz: ");

                // Kullanıcının girdiği değer okunur ve int'e dönüştürülür
                int secim = Convert.ToInt32(Console.ReadLine());

                // 0 girilirse alışveriş biter
                if (secim == 0)
                {
                    devam = false; // Döngü sona erecek
                    Console.WriteLine("Kasaya geçiliyor..."); // Bilgi mesajı
                }
                // Eğer 1–5 arası geçerli bir ürün seçildiyse:
                else if (secim >= 1 && secim <= urunler.Length)
                {
                    // Seçilen ürünün adı ekrana yazdırılır
                    Console.WriteLine("Seçilen ürün: " + urunler[secim - 1].Ad);

                    // Kullanıcıdan adet bilgisi alınır
                    Console.Write("Kaç adet alacaksınız: ");

                    // Girilen değer double tipine dönüştürülür (örneğin 2 veya 2.5)
                    double adet = Convert.ToDouble(Console.ReadLine());

                    // Ara toplam hesaplanır → fiyat × adet
                    double araToplam = urunler[secim - 1].Fiyat * adet;

                    // Toplam tutara eklenir
                    toplam += araToplam;

                    // Ekrana bilgilendirme yapılır
                    // Örnek: "2 x Süt eklendi. Ara toplam: 30 TL"
                    Console.WriteLine(adet + " x " + urunler[secim - 1].Ad +
                                      " eklendi. Ara toplam: " + araToplam + " TL");
                }
                // Eğer geçersiz bir sayı girildiyse (örneğin 6, -1, 100)
                else
                {
                    Console.WriteLine("Geçersiz ürün numarası! Lütfen 1–5 arası bir sayı giriniz.");
                }
            }

            // Döngü bittiğinde toplam tutar gösterilir
            Console.WriteLine("\nToplam Tutar: " + toplam + " TL");

            // Kullanıcıya öğrenci olup olmadığı sorulur
            Console.Write("Öğrenci misiniz? (1 = Evet, 2 = Hayır): ");

            // Kullanıcının cevabı int'e dönüştürülür
            int ogrenciSecim = Convert.ToInt32(Console.ReadLine());

            // Öğrenci indirimi uygulanması kontrol edilir
            if (ogrenciSecim == 1)
            {
                // Toplamın %10'u kadar indirim hesaplanır
                double indirim = toplam * 0.1;

                // Toplamdan indirim düşülür
                toplam -= indirim;

                // Kullanıcıya bilgi verilir
                Console.WriteLine("Öğrenci indirimi uygulandı! -" + indirim + " TL");
            }
            // Öğrenci değilse
            else if (ogrenciSecim == 2)
            {
                Console.WriteLine("Normal fiyat uygulanacaktır.");
            }
            // Geçersiz seçim yaparsa
            else
            {
                Console.WriteLine("Geçersiz giriş! İndirim uygulanmadı.");
            }

            // Ödenecek son tutar ekrana yazdırılır
            Console.WriteLine("Ödenecek Tutar: " + toplam + " TL");

            // Program sonu mesajı
            Console.WriteLine("\nTeşekkür ederiz, iyi günler!");
        }
    }
}
