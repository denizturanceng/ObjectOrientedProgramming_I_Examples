using System; // Konsol işlemleri için gerekli kütüphane

// "Karakter" adında bir sınıf oluşturuyoruz
class Karakter
{
    // --- Alanlar (Fields) ---
    private int seviye; // dışarıdan değiştirilemez, sadece sınıf içinden kontrol edilir
    private int can;    // karakterin can puanı (0–100 arası)
    public string Ad;   // karakterin adı (herkese açık)

    // --- Constructor (kurucu metot) ---
    // Karakter oluşturulurken adı ve başlangıç seviyesi kullanıcıdan alınır
    public Karakter(string ad, int seviye)
    {
        this.Ad = ad;          // parametreden gelen "ad" değeri sınıfın Ad alanına atanır
        this.seviye = seviye;  // başlangıç seviyesi atanır
        this.can = 100;        // her karakter tam canla başlar
    }

    // --- Hasar alma metodu ---
    public void HasarAl(int miktar)
    {
        if (miktar > 0) // sadece pozitif hasar değerleri kabul edilir
        {
            can -= miktar; // karakterin canı azalır

            if (can <= 0)
            {
                can = 0; // negatif olmasın diye sıfıra sabitlenir
                Console.WriteLine(Ad + " öldü! ☠️");
            }
            else
            {
                Console.WriteLine(Ad + " " + miktar + " hasar aldı. Kalan can: " + can);
            }
        }
        else
        {
            Console.WriteLine("Geçersiz hasar miktarı!");
        }
    }

    // --- Seviye atlama metodu ---
    public void SeviyeAtla()
    {
        seviye++;    // karakter seviyesi 1 artar
        can = 100;   // seviye atlayınca can yenilenir
        Console.WriteLine(Ad + " seviye atladı! Yeni seviye: " + seviye);
    }

    // --- Bilgileri ekrana yazdıran metot ---
    public void BilgiYazdir()
    {
        Console.WriteLine("\n🎮 Karakter Bilgisi");
        Console.WriteLine("Ad: " + Ad + " | Seviye: " + seviye + " | Can: " + can);
    }
}

// Ana program
class Program
{
    static void Main()
    {
        bool devam = true;         // Menü döngüsü kontrolü
        Karakter karakter = null;  // Henüz karakter oluşturulmadı

        while (devam)
        {
            // Menü başlığı
            Console.WriteLine("\n=== OYUN MENÜSÜ ===");
            Console.WriteLine("1. Yeni Karakter Oluştur");
            Console.WriteLine("2. Hasar Al");
            Console.WriteLine("3. Seviye Atla");
            Console.WriteLine("4. Bilgileri Görüntüle");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");

            string secim = Console.ReadLine(); // Kullanıcıdan menü seçimi alınır

            switch (secim)
            {
                case "1":
                    // Karakter oluşturma
                    Console.Write("Karakter Adı: ");
                    string ad = Console.ReadLine();

                    Console.Write("Başlangıç Seviyesi: ");
                    int seviye = Convert.ToInt32(Console.ReadLine());

                    // Yeni karakter nesnesi oluşturuluyor
                    karakter = new Karakter(ad, seviye);
                    Console.WriteLine("✅ Karakter başarıyla oluşturuldu!");
                    break;

                case "2":
                    // Karakter oluşturulmuşsa hasar işlemi yapılır
                    if (karakter != null)
                    {
                        Console.Write("Hasar miktarı: ");
                        int hasar = Convert.ToInt32(Console.ReadLine());
                        karakter.HasarAl(hasar); // metot çağrılır
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Önce bir karakter oluşturmalısınız!");
                    }
                    break;

                case "3":
                    // Seviye atlama işlemi
                    if (karakter != null)
                        karakter.SeviyeAtla();
                    else
                        Console.WriteLine("Henüz bir karakter oluşturulmadı!");
                    break;

                case "4":
                    // Bilgi görüntüleme
                    if (karakter != null)
                        karakter.BilgiYazdir();
                    else
                        Console.WriteLine("Karakter bilgisi mevcut değil!");
                    break;

                case "0":
                    // Program sonlandırma
                    devam = false;
                    Console.WriteLine("Oyun kapatılıyor...");
                    break;

                default:
                    // Hatalı giriş durumu
                    Console.WriteLine("Geçersiz seçim! Lütfen 0–4 arasında bir değer giriniz.");
                    break;
            }
        }
    }
}
