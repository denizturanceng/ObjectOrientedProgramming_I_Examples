using System; // Konsol işlemleri için temel kütüphane

// "Kargo" adında bir sınıf oluşturuyoruz
class Kargo
{
    // Her kargonun tutacağı bilgiler (özellikler)
    public string Alici; // Alıcı adı
    public string Adres; // Teslimat adresi
    public double Ucret; // Ücret bilgisi

    // Constructor (kurucu metot) → Nesne oluşturulurken ilk değerleri alır
    public Kargo(string alici, string adres, double ucret)
    {
        // "this" anahtar kelimesi → sınıf içindeki değişken ile parametreyi ayırır
        this.Alici = alici;
        this.Adres = adres;
        this.Ucret = ucret;
    }

    // Kargo bilgilerini ekrana yazdıran metot
    public void BilgiYazdir()
    {
        Console.WriteLine("\n🚚 Kargo Bilgisi");
        Console.WriteLine("Alıcı: " + Alici);
        Console.WriteLine("Adres: " + Adres);
        Console.WriteLine("Ücret: " + Ucret + " TL");
    }
}

// Ana program sınıfı
class Program
{
    static void Main()
    {
        bool devam = true; // Menü döngüsünü kontrol eder
        Kargo kayitliKargo = null; // Henüz kargo oluşturulmadı, null = boş referans

        // Kullanıcı çıkmak isteyene kadar menü dönsün
        while (devam)
        {
            // Menü başlığı
            Console.WriteLine("\n=== KARGO TAKİP MENÜSÜ ===");
            Console.WriteLine("1. Yeni Kargo Oluştur");
            Console.WriteLine("2. Kargo Bilgisi Görüntüle");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");

            string secim = Console.ReadLine(); // Kullanıcı seçimi alınır

            switch (secim)
            {
                case "1":
                    // Yeni kargo bilgileri alınır
                    Console.Write("Alıcı Adı: ");
                    string alici = Console.ReadLine();

                    Console.Write("Adres: ");
                    string adres = Console.ReadLine();

                    Console.Write("Ücret (TL): ");
                    double ucret = Convert.ToDouble(Console.ReadLine());

                    // Kullanıcıdan alınan bilgilerle yeni kargo nesnesi oluşturulur
                    kayitliKargo = new Kargo(alici, adres, ucret);

                    Console.WriteLine("✅ Kargo başarıyla oluşturuldu!");
                    break;

                case "2":
                    // Kayıtlı kargo var mı kontrol edilir
                    if (kayitliKargo != null)
                    {
                        kayitliKargo.BilgiYazdir(); // Bilgiler gösterilir
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Henüz bir kargo oluşturmadınız!");
                    }
                    break;

                case "0":
                    // Çıkış işlemi
                    devam = false;
                    Console.WriteLine("Program sonlandırıldı.");
                    break;

                default:
                    // Menü dışı giriş kontrolü
                    Console.WriteLine("Geçersiz seçim! Lütfen 0, 1 veya 2 giriniz.");
                    break;
            }
        }
    }
}
