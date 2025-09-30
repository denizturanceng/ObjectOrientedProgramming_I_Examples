using System;

class Program
{
    // Kişisel bilgileri tutan struct
    public struct Person
    {
        // Temel kişisel bilgiler alan olarak tutuluyor
        public string Name;
        public string Surname;
        public int Age;

        // İç içe struct: Vücut bilgilerini temsil eder
        public struct BodyInfo
        {
            public double Height; // metre cinsinden boy
            public double Weight; // kilogram cinsinden kilo

            // ----------------- PRIVATE METOTLAR -----------------

            // BMI (Body Mass Index = Vücut Kitle İndeksi) hesaplama
            // Yalnızca struct içinden çağrılabilir.
            private double CalculateBMI()
            {
                // BMI formülü: kilo / (boy^2)
                return Weight / (Math.Pow(Height, 2));
            }

            // BMI sonucuna göre yorum döndüren metot
            private string GetBMIComment(double index)
            {
                if (index < 18.5) return "Kilo almanız önerilir.";
                else if (index >= 18.5 && index < 25) return "İdeal kilonuzdasınız.";
                else if (index >= 25 && index < 30) return "Fazla kilolusunuz, dikkat etmelisiniz.";
                else return "Obezite sınırı.";
            }

            // ----------------- PUBLIC METOT -----------------

            // BMI değerini hesaplayıp ekrana yazdırır
            public void ShowBodyInfo()
            {
                double index = CalculateBMI(); // önce BMI hesaplanır
                Console.WriteLine($"Vücut Kitle Endeksi: {index:F2}, Durum: {GetBMIComment(index)}");
                //C#’ta F2 ifadesi bir formatlama belirtecidir (standard numeric format string).
                //Bu, sayının kendisini değiştirmez; sadece ekrana yazdırılırken görünümünü değiştirir.
                //Yuvarlama yapar. Örneğin 12.34567 → F2 ile 12,35 olur.
                //F sadece float/ double ile ilgili değildir; int, decimal gibi sayılarla da kullanılabilir.
            }
        }

        // Kişisel bilgileri ve body bilgilerini birlikte yazdırır
        public void ShowPersonInfo(BodyInfo body)
        {
            Console.WriteLine($"İsim: {Name} {Surname}, Yaş: {Age}");
            body.ShowBodyInfo(); // İçteki struct'ın metodunu çağırarak BMI bilgisini gösterir
        }
    }

    static void Main(string[] args)
    {
        // Struct örnekleri oluşturuluyor
        Person person = new Person();
        Person.BodyInfo body = new Person.BodyInfo();

        Console.WriteLine("=== Vücut Kitle İndeksi Hesaplayıcı ===");

        // Kullanıcıdan kişisel bilgiler alınıyor
        Console.Write("İsim: ");
        person.Name = Console.ReadLine();

        Console.Write("Soyad: ");
        person.Surname = Console.ReadLine();

        Console.Write("Yaş: ");
        person.Age = Convert.ToInt32(Console.ReadLine());

        // Kullanıcıdan vücut bilgileri alınıyor
        Console.Write("Boy (metre): ");
        // Replace(".", ",") → Türkçe sistemlerde ondalık ayırıcı uyumsuzluğunu önlemek için
        body.Height = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        Console.Write("Kilo (kg): ");
        body.Weight = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        // Sonuç gösteriliyor
        Console.WriteLine("\n--- Sonuç ---");
        person.ShowPersonInfo(body);
    }
}
