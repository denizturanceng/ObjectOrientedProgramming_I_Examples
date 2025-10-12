using System; // Giriş-çıkış işlemleri için System kütüphanesini kullanıyoruz

// "Kitap" adında bir sınıf tanımlıyoruz
class Kitap
{
    // Her kitap nesnesinin sahip olacağı bilgiler (alanlar)
    public string Ad;     // Kitabın adı
    public string Yazar;  // Kitabın yazarı
    public int Yil;       // Kitabın yayın yılı

    // Kitap bilgilerini kullanıcıdan alan metot
    public void BilgiGir()
    {
        // Kullanıcıdan kitap adı alınır
        Console.Write("Kitap Adı: ");
        Ad = Console.ReadLine();  // Girilen veri Ad değişkenine atanır

        // Kullanıcıdan yazar bilgisi alınır
        Console.Write("Yazar: ");
        Yazar = Console.ReadLine();

        // Kullanıcıdan yayın yılı alınır
        Console.Write("Yayın Yılı: ");
        Yil = Convert.ToInt32(Console.ReadLine()); // String giriş integer'a çevrilir
    }

    // Kitap bilgilerini ekrana yazdıran metot
    public void BilgiYazdir()
    {
        // Ekranda kitap detaylarını gösterir
        Console.WriteLine("\n📘 Kitap Bilgisi");
        Console.WriteLine("Ad: " + Ad);
        Console.WriteLine("Yazar: " + Yazar);
        Console.WriteLine("Yıl: " + Yil);
    }
}

// Ana program burada başlıyor
class Program
{
    // Main metodu: programın çalıştığı giriş noktasıdır
    static void Main()
    {
        bool devam = true;  // Menü sürekli dönebilsin diye kontrol değişkeni
        Kitap kitap = new Kitap();  // Kitap sınıfından bir nesne oluşturuyoruz

        // Kullanıcı çıkmak isteyene kadar menüyü döngüyle gösteriyoruz
        while (devam)
        {
            // Menü ekranı
            Console.WriteLine("\n=== KÜTÜPHANE MENÜSÜ ===");
            Console.WriteLine("1. Kitap Bilgisi Ekle");
            Console.WriteLine("2. Kitap Bilgisi Görüntüle");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");

            string secim = Console.ReadLine(); // Kullanıcıdan menü seçimi alınır

            // Kullanıcının seçimine göre işlem yapılır
            if (secim == "1")
            {
                // 1 seçildiyse kullanıcıdan kitap bilgileri alınır
                kitap.BilgiGir();
            }
            else if (secim == "2")
            {
                // 2 seçildiyse mevcut kitap bilgileri gösterilir
                kitap.BilgiYazdir();
            }
            else if (secim == "0")
            {
                // 0 girilirse döngü sona erer ve program kapanır
                devam = false;
                Console.WriteLine("Program sonlandırıldı.");
            }
            else
            {
                // Tanımlı olmayan bir değer girilirse hata mesajı
                Console.WriteLine("Geçersiz seçim! Lütfen 0, 1 veya 2 giriniz.");
            }
        }
    }
}