using System;

namespace stringMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== STRING METHODLARI DEMO ===\n");

            // Örnek string değişkenler
            string str1 = "Merhaba Dünya";       // İçinde Türkçe karakter var
            string str2 = "merhaba dünya";       // Küçük harfli versiyon
            string str3 = "     Merhaba Dünya     "; // Başında ve sonunda boşluklar var

            // ---------------- TEMEL ÖZELLİKLER ----------------

            // Length → string uzunluğunu döner
            Console.WriteLine("Uzunluk (Length): " + str1.Length);

            // ToUpper / ToLower → büyük-küçük harfe çevirme
            Console.WriteLine("Büyük Harf: " + str1.ToUpper()); // MERHABA DÜNYA
            Console.WriteLine("Küçük Harf: " + str1.ToLower()); // merhaba dünya

            // ---------------- KARŞILAŞTIRMA ----------------

            // Compare → iki string’i karşılaştırır
            // 0: eşit, negatif: birinci < ikinci, pozitif: birinci > ikinci
            Console.WriteLine("Compare (str1, str2): " + String.Compare(str1, str2));
            Console.WriteLine("Compare (case-insensitive): " +
                String.Compare(str1, str2, true)); // true → harf duyarsız karşılaştırma

            // Equals → eşitlik kontrolü, bool döner
            Console.WriteLine("Equals (str1 == str2): " + str1.Equals(str2));
            Console.WriteLine("Equals (IgnoreCase): " +
                str1.Equals(str2, StringComparison.OrdinalIgnoreCase));

            // ---------------- ARAMA & KONTROL ----------------

            // StartsWith / EndsWith → başlangıç veya bitiş kontrolü
            Console.WriteLine("StartsWith 'Mer': " + str1.StartsWith("Mer"));
            Console.WriteLine("EndsWith 'Dünya': " + str1.EndsWith("Dünya"));

            // Contains → içinde geçiyor mu kontrolü
            Console.WriteLine("Contains 'haba': " + str1.Contains("haba"));

            // IndexOf / LastIndexOf → karakter veya substring’in indeksini bulma
            Console.WriteLine("IndexOf 'a': " + str1.IndexOf('a'));       // ilk 'a'
            Console.WriteLine("LastIndexOf 'a': " + str1.LastIndexOf('a'));// son 'a'

            // ---------------- ALT STRING İŞLEMLERİ ----------------

            // Substring → string’in belli bir bölümünü alma
            Console.WriteLine("Substring(0,9): " + str1.Substring(0, 9)); // "Merhaba D"

            // Insert → string’e ekleme
            Console.WriteLine("Insert: " + str1.Insert(7, " Güzel")); // "Merhaba Güzel Dünya"

            // Remove → belli kısımları silme
            Console.WriteLine("Remove(9): " + str1.Remove(9));        // 9. indexten sonrasını sil → "Merhaba D"
            Console.WriteLine("Remove(7,5): " + str1.Remove(7, 5));   // 7’den itibaren 5 karakter sil

            // Replace → karakter veya metin değiştirme
            Console.WriteLine("Replace 'Dünya' → 'C#': " + str1.Replace("Dünya", "C#"));

            // ---------------- BOŞLUK İŞLEMLERİ ----------------

            // Trim / TrimStart / TrimEnd → boşlukları temizleme
            Console.WriteLine("Orijinal (boşluklu): -" + str3 + "-");
            Console.WriteLine("Trim: -" + str3.Trim() + "-");         // Baş/son tüm boşlukları siler
            Console.WriteLine("TrimStart: -" + str3.TrimStart() + "-"); // Sadece baştaki boşlukları siler
            Console.WriteLine("TrimEnd: -" + str3.TrimEnd() + "-");     // Sadece sondaki boşlukları siler

            // ---------------- HİZALAMA ----------------

            // PadLeft / PadRight → belirli uzunluğa boşluk/karakter ekleyerek hizalama
            Console.WriteLine("PadLeft(20, '*'): " + str1.PadLeft(20, '*'));
            Console.WriteLine("PadRight(20, '-'): " + str1.PadRight(20, '-'));

            // ---------------- DİZİ İŞLEMLERİ ----------------

            // Split → string’i parçalama (boşluğa göre)
            string[] kelimeler = str1.Split(' ');
            Console.WriteLine("Split ile parçalanan kelimeler:");
            foreach (string k in kelimeler)
                Console.WriteLine("- " + k);

            // Join → string dizisini birleştirme
            string joined = String.Join(" | ", kelimeler);
            Console.WriteLine("Join: " + joined);

            // ToCharArray → string’i karakter dizisine çevirme
            char[] harfler = str1.ToCharArray();
            Console.WriteLine("ToCharArray:");
            foreach (char c in harfler)
                Console.Write(c + " "); // karakterleri tek tek yazdırır
            Console.WriteLine();

            // ---------------- BİÇİMLENDİRME ----------------

            // Format → eski yöntemle string biçimlendirme
            string ad = "Deniz";
            int yas = 25;
            Console.WriteLine(String.Format("Ad: {0}, Yaş: {1}", ad, yas));
            Console.WriteLine("Ad:" + ad + " Yaş:" + yas); // klasik birleştirme

            // Interpolation ($) → modern biçimlendirme yöntemi
            Console.WriteLine($"Ad: {ad}, Yaş: {yas}");

            // ---------------- BİRLEŞTİRME ----------------

            // Concat → stringleri birleştirme
            string birlesik = String.Concat(str1, " ", str2);
            Console.WriteLine("Concat: " + birlesik);

            // Copy → string kopyalama (C# 8.0’dan sonra önerilmez, çünkü gereksiz)
            string kopya = String.Copy(str1);
            Console.WriteLine("Copy: " + kopya);

            // ---------------- BOŞ KONTROLÜ ----------------

            // IsNullOrEmpty / IsNullOrWhiteSpace → boş mu kontrolü
            string bos = "";
            Console.WriteLine("IsNullOrEmpty: " + String.IsNullOrEmpty(bos));       // true
            Console.WriteLine("IsNullOrWhiteSpace: " + String.IsNullOrWhiteSpace("   ")); // true

            Console.WriteLine("\n=== BİTTİ ===");
            Console.ReadLine(); // Konsol kapanmasın diye bekleme
        }
    }
}
