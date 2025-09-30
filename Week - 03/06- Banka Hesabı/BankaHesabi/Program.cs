using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHesabi
{
    // Programın çalışacağı ana sınıf
    internal class Program
    {
        // Struct: BankaHesabi
        // Burada bir banka hesabını temsil eden veri yapısı tanımlıyoruz.
        // İçinde sadece bakiye (para miktarı) saklanıyor ve bu bakiyeyi
        // değiştirecek/gösterecek metotlar yer alıyor.
        public struct BankaHesabi
        {
            // Hesap bakiyesini tutan özel alan (encapsulation: dışarıdan direkt erişilemez)
            private double bakiye;

            // ---------------- METOTLAR ----------------

            // Para yatırma işlemi
            public void ParaYatirma(double miktar)
            {
                // Pozitif miktar kontrolü (negatif veya 0 yatırılamaz)
                if (miktar > 0)
                {
                    bakiye += miktar; // bakiyeye ekleme
                    Console.WriteLine(
                        miktar + " TL bakiyenize eklenmiştir. Güncel Bakiyeniz: " + bakiye + " TL"
                    );
                }
                else
                {
                    Console.WriteLine("Geçersiz İşlem"); // yanlış giriş için uyarı
                }
            }

            // Para çekme işlemi
            public void ParaCekme(double miktar)
            {
                // Hem pozitif olmalı hem de mevcut bakiyeden fazla olmamalı
                if (miktar > 0 && miktar <= bakiye)
                {
                    bakiye -= miktar; // bakiyeden çıkarma
                    Console.WriteLine(
                        miktar + " TL kadar bakiyenizden para çekilmiştir. Güncel Bakiyeniz: " + bakiye + " TL"
                    );
                }
                else
                {
                    Console.WriteLine("Geçersiz İşlem"); // negatif, sıfır ya da yetersiz bakiye
                }
            }

            // Güncel bakiyeyi döndüren metot
            // Get kullanımı → "bakiye değerini dışarıya sadece okumak için açıyoruz".
            public double GetBakiye()
            {
                return bakiye;
            }
        }

        // Programın giriş noktası
        static void Main(string[] args)
        {
            // Yeni bir banka hesabı oluşturuluyor
            BankaHesabi hesap = new BankaHesabi();

            Console.WriteLine("BANKA HESAP UYGULAMASI");

            // Kullanıcı çıkış yapmak isteyene kadar sürecek döngü
            bool cikisTalebi = false;

            while (!cikisTalebi)
            {
                // Menü seçenekleri ekrana yazdırılıyor
                Console.WriteLine("1- Para Yatırma");
                Console.WriteLine("2- Para Çekme");
                Console.WriteLine("3- Bakiye Sorgulama");
                Console.WriteLine("4- Çıkış");

                // Kullanıcının menü seçimini alıyoruz
                int secim = Convert.ToInt32(Console.ReadLine());

                // Seçime göre farklı işlem yapılacak
                switch (secim)
                {
                    case 1: // Para Yatırma
                        Console.WriteLine("Yatırmak istediğiniz miktarı giriniz:");
                        double yatirilacak = Convert.ToDouble(Console.ReadLine());
                        hesap.ParaYatirma(yatirilacak);
                        break;

                    case 2: // Para Çekme
                        Console.WriteLine("Çekmek istediğiniz miktarı giriniz:");
                        double cekilecek = Convert.ToDouble(Console.ReadLine());
                        hesap.ParaCekme(cekilecek);
                        break;

                    case 3: // Bakiye Sorgulama
                        Console.WriteLine("Güncel Bakiye: " + hesap.GetBakiye());
                        break;

                    case 4: // Çıkış
                        cikisTalebi = true; // Döngüyü sonlandır
                        break;

                    default:
                        // Kullanıcı 1-4 dışında bir sayı girerse
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                        break;
                }
            }
        }
    }
}
