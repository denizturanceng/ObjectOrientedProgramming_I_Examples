using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvFaturaTakipSistemi
{
    class Ev
    {
        // === Private alanlar ===
        private string evSahibi;
        private double bakiye;
        private double elektrikBorc;
        private double suBorc;

        // === Constructor (ilk değer atama) ===
        public Ev(string sahip, double baslangicBakiyesi) // constructor metodu sınıfla aynı isimde olur. Parametre alan değişkenlerin başlangıç değerleri Main metotunun içinde nesne yaratırken atandı 119.satıra bakabilirsiniz.
        {
            evSahibi = sahip;
            bakiye = baslangicBakiyesi;
            elektrikBorc = 0;
            suBorc = 0;
        }

        // === Kapsülleme: dışarıdan erişimi kontrol eden public metotlar ===

        // Para yatırma (bakiye artırma)
        public void ParaYatir(double miktar)
        {
            if (miktar > 0)
            {
                bakiye += miktar;
                Console.WriteLine(miktar + " TL yatırıldı. Yeni bakiye: "+bakiye +" TL");
            }
            else
            {
                Console.WriteLine("Geçersiz miktar!");
            }
        }

        // Fatura ekleme
        public void FaturaEkle(string tur, double tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Geçersiz fatura tutarı!");
                return;
            }

            if (tur == "elektrik")
                elektrikBorc += tutar;
            else if (tur == "su")
                suBorc += tutar;
            else
                Console.WriteLine("Bilinmeyen fatura türü!");
        }

        // Fatura ödeme
        public void FaturaOde(string tur, double tutar)
        {
            // ödenecek fatura ne faturası ? Bunu tur parametresi ile tutuyoruz.

            // Buralarda atılan returnlerin amacı ne ? Return mantığını anlamamız gerekiyor arkadaşlar. Bu nedenle aşağıda detaylıca açıkladım.


            if (tutar <= 0)
            {
                Console.WriteLine("Geçersiz ödeme tutarı!");
                return; // Bir fatura ödemek için 0 veya daha düşük miktar girişi mantıksız. Bunu kabul etmiyoruz.
                        // Tutar mantıksız olduğunda metodun(C ve C++ 'ta fonksiyon, C#'ta metot) aşağısındaki diğer
                        // kodların okunmasına gerek yok. Direkt çıkış yapmamız gerekiyor ondan return kullandık.
                        // yani kısaca buradaki returnler koşul sağlanmadığında metottan erken çıkmayı sağlar.
            }

            if (tutar > bakiye)
            {
                Console.WriteLine("Yetersiz bakiye!");
                return;// Yetersiz bakiye olduğu için  Bunu kabul etmiyoruz.
                       // Tutar mantıksız olduğunda metodun(C ve C++ 'ta fonksiyon, C#'ta metot) aşağısındaki diğer
                       // kodların okunmasına gerek yok. Direkt çıkış yapmamız gerekiyor ondan return kullandık. 
            }

            if (tur == "elektrik" && tutar <= elektrikBorc) // aynı classta olduğumuz için private bile olsa elektrikBorc değişkenine erişebiliyoruz.
            {
                elektrikBorc -= tutar; // Burada aslında elektrikBorc = elektrikBorc - tutar yaptık. Bunun kısa yazımını yazdım.
                bakiye -= tutar; // Burada aslında bakiye = bakiye - tutar yaptık. Bunun kısa yazımını yazdım.
                Console.WriteLine("Elektrik faturası için " + tutar+" TL ödendi.");
            }
            else if (tur == "su" && tutar <= suBorc) // aynı classta olduğumuz için private bile olsa suBorc değişkenine erişebiliyoruz.
            {
                suBorc -= tutar; // Burada aslında suBorc = suBorc - tutar yaptık. Bunun kısa yazımını yazdım.
                bakiye -= tutar; // Burada aslında bakiye = bakiye - tutar yaptık. Bunun kısa yazımını yazdım.
                Console.WriteLine("Su faturası için " + tutar+" TL ödendi.");
            }
            else
            {
                Console.WriteLine("Geçersiz fatura türü veya tutar!");
            }
        }

        // Durum görüntüleme
        public void DurumYazdir()
        {
            Console.WriteLine("\n=== Güncel Durum ===");
            Console.WriteLine($"Ev Sahibi : {evSahibi}");
            Console.WriteLine($"Mevcut Bakiye     : {bakiye} TL");
            Console.WriteLine($"Kalan Elektrik Borcu  : {elektrikBorc} TL");
            Console.WriteLine($"Kalan Su Borcu        : {suBorc} TL");
            Console.WriteLine("=====================");
        }
    }

    class Program
    {
        static void Main() // Arkadaşlar bizim ana metotudmuz Main metotu. program buradan çalışmaya başlıyor. Siz ne kadar yuköarıda sınıf tanımlarsanız tanımlayın Main metodunda çağırmazsanız kullanamazsınız.
        {
            // Constructor ile nesne oluşturuluyor
            Ev ev1 = new Ev("Cristiano Ronaldo", 1000); // Burada sınıftan nesne yaratılıyor. Ev sınıfından ev1 nesnesini yaratıyoruz. 
                                                        // Sadece tek nesne yaratmayabiliriz. Siz isterseniz ev2 diye ikinci bir nesne yaratıp örneği geliştirebilirsiniz.
                                                        // Constructor(yapıcı model) kullandığımız için de başlangıç değerlerini atayabildik. Siz Ronaldo yerine kendi isminizi yazabilirsiniz :)

            ev1.FaturaEkle("elektrik", 300); // metot için parametre geçiyoruz. FaturaEkle metoduna bakltığınızda verdiğimiz parametreye göre yönlendirme bariz şekilde belli oluyor. Aşağıdaki diğer metotlar da aynı şekilde.
            ev1.FaturaEkle("su", 150);
            ev1.DurumYazdir();

            ev1.FaturaOde("elektrik", 200);
            ev1.FaturaOde("su", 100);
            ev1.DurumYazdir();

            ev1.ParaYatir(500);
            ev1.FaturaEkle("elektrik", 50);
            ev1.FaturaOde("elektrik", 100);
            ev1.DurumYazdir();
        }
    }

}
