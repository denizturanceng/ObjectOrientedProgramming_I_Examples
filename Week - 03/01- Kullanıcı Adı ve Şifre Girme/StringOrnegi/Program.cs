using System;

class Program
{
    static void Main()
    {
        // Sonsuz döngü → doğru kullanıcı adı ve şifre girilene kadar tekrar edecek
        while (true)
        {
            Console.WriteLine("Hoşgeldiniz. Kullanıcı adı giriniz.");
            string kullaniciAdi = Console.ReadLine(); // kullanıcı adını oku

            // Kullanıcı adı uzunluk kontrolü
            if (kullaniciAdi.Length < 5)
            {
                Console.WriteLine("En az beş karakterli bir kullanıcı adı girin.");
                continue; // tekrar döngünün başına dön
            }

            // Şifre alınıyor
            Console.WriteLine("Şifreyi girin: ");
            string sifre = Console.ReadLine();

            // Flag değişkenler (kontrol için bayraklar)
            bool rakamVar = false;     // şifre içinde rakam var mı?
            bool buyukHarfVar = false; // şifre içinde büyük harf var mı?

            // Şifredeki her karakteri tek tek incele
            foreach (char c in sifre) // örn: "Deniz35" → D e n i z 3 5
            {
                if (Char.IsDigit(c))       // Karakter rakam mı? (0–9)
                {
                    rakamVar = true;
                }
                if (Char.IsUpper(c))       // Karakter büyük harf mi? (A–Z)
                {
                    buyukHarfVar = true;
                }
            }

            // Koşullar kontrol ediliyor
            if (rakamVar == true && buyukHarfVar == true)
            {
                // Şifre kurallara uygunsa giriş başarılı
                Console.WriteLine("Kullanıcı adı ve şifre geçerli. Hoşgeldiniz " + kullaniciAdi);
                break; // while döngüsünden çık
            }
            else
            {
                // Şifre kurallara uymuyorsa tekrar iste
                Console.WriteLine("Kullanıcı adı ve şifre geçersiz.");
            }
        }

        // Program kapanmasın diye ek okuma
        Console.ReadLine();

        /*
            ÖZET:

            1) Kullanıcı adı en az 5 karakter olmalı.
            2) Şifre içinde en az 1 rakam (0–9) olmalı.
            3) Şifre içinde en az 1 büyük harf (A–Z) olmalı.
            4) Kurallara uyulmazsa kullanıcıdan tekrar istenir.
            5) Doğru giriş yapıldığında "Hoşgeldiniz X" mesajı gösterilir.
        */
    }
}
