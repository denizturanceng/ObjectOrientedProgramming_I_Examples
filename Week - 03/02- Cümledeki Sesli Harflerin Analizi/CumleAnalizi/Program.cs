using System;
using System.Linq;

namespace CumleAnalizi
{
    class Program
    {
        static void Main()
        {
            // Kullanıcıdan bir cümle alıyoruz
            Console.Write("Bir cümle girin: ");
            string cumle = Console.ReadLine();

            Console.WriteLine("\n--- Metin Analizi ---");
            Console.WriteLine("Orijinal cümle: " + cumle);

            // 1. Uzunluk (Length) → Toplam karakter sayısını verir
            // Boşluk ve noktalama işaretleri de bu sayıya dahildir
            Console.WriteLine("Uzunluk: " + cumle.Length);

            // 2. Cümlenin tümünü büyük/küçük harfe çevirme
            Console.WriteLine("Büyük harf: " + cumle.ToUpper());
            Console.WriteLine("Küçük harf: " + cumle.ToLower());

            // 3. Cümle içinde kelime arama
            Console.Write("Aranacak kelimeyi gir: ");
            string kelime = Console.ReadLine();

            // Contains → kelimenin olup olmadığını kontrol eder
            // IndexOf → kelimenin bulunduğu ilk konumun indeksini verir (-1 değilse var demektir)
            if (cumle.Contains(kelime))
                Console.WriteLine("Kelime bulundu! Index: " + cumle.IndexOf(kelime));
            else
                Console.WriteLine("Kelime bulunamadı.");

            // 4. Kaç kelime var?
            // Split(' ') → boşluklara göre cümleyi parçalar
            // Not: Birden fazla boşluk varsa boş string de diziye girebilir
            string[] parcala = cumle.Split(' ');
            Console.WriteLine("Kelime sayısı: " + parcala.Length);

            // 5. Cümleyi ters çevirme
            // ToCharArray → cümleyi karakter dizisine dönüştürür
            // Array.Reverse → diziyi tersine çevirir
            char[] harfler = cumle.ToCharArray();
            Array.Reverse(harfler);
            Console.WriteLine("Ters çevrilmiş: " + new string(harfler));

            // 6. Sesli harf sayısı
            int sesli = 0;
            foreach (char c in cumle.ToLower()) // Küçük harfe çevirip kontrol yapıyoruz
            {
                // Türkçe sesli harfler
                if ("aeıioöuü".Contains(c))
                    sesli++;
            }
            Console.WriteLine("Sesli harf sayısı: " + sesli);
        }
    }
}
