# VIRTUAL CAT SIMULATOR – C# WINFORMS DIY LAB

Bu laboratuvar çalışmasında C# Windows Forms ve Nesneye Yönelik Programlama (OOP) tekniklerini kullanarak basit bir Sanal Kedi Simülatörü geliştireceğiz.

---------------------------------------------------------
0. PROJE OLUŞTURMA
---------------------------------------------------------
1. Visual Studio → File → New → Project
2. “Windows Forms App (.NET Framework)” şablonunu seçin
3. Proje adı: VirtualCatSimulator
4. Oluşturun

---------------------------------------------------------
1. VirtualCat.cs (OOP Sınıf Tasarımı)
---------------------------------------------------------

Solution Explorer → Add → Class → VirtualCat.cs

Aşağıdaki kodu ekleyin:
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCatSimulator
{
    public class VirtualCat
    {
        // Kedinin adı
        public string Name { get; set; }

        // Açlık değeri
        public int Hunger { get; private set; }

        // Enerji değeri
        public int Energy { get; private set; }

        // Oynama isteği
        public int Playfulness { get; private set; }

        // Constructor – kedi oluşturulduğunda başlangıç değerleri verilir
        public VirtualCat(string name)
        {
            Name = name;
            Hunger = 80;
            Energy = 80;
            Playfulness = 80;
        }

        // Yemek verildiğinde açlık artar
        public void Feed()
        {
            Hunger = Math.Min(100, Hunger + 20);
        }

        // Oyun oynadığında oyun isteği artar
        public void Play()
        {
            Playfulness = Math.Min(100, Playfulness + 20);
        }

        // Uyuduğunda enerji artar
        public void Sleep()
        {
            Energy = Math.Min(100, Energy + 25);
        }

        // Her saniye geçen süreye göre statlar azalır
        public void Tick()
        {
            Hunger = Math.Max(0, Hunger - 10);
            Energy = Math.Max(0, Energy - 5);
            Playfulness = Math.Max(0, Playfulness - 20);
        }
    }
}
```
---------------------------------------------------------
2. KEDİ GÖRSELLERİNİ EKLE
---------------------------------------------------------

1. Solution Explorer → Properties
2. Resources sekmesi
3. Add Resource → Add Existing File
   - happy_cat.png
   - sad_cat.png

Kod içinde şöyle kullanılır:

Properties.Resources.happy_cat
Properties.Resources.sad_cat

---------------------------------------------------------
3. PetScreenForm OLUŞTURMA
---------------------------------------------------------

Solution Explorer → Add → Windows Form → PetScreenForm.cs

Bu forma şu nesneleri yerleştirin:

PictureBox  → pictureBoxCat  
ProgressBar → progressHunger  
ProgressBar → progressEnergy  
ProgressBar → progressPlay  
Button      → btnFeed  
Button      → btnSleep  
Button      → btnPlay  
Button      → btnBack  
Timer       → timerStats (Interval: 1000 ms)

---------------------------------------------------------
4. PetScreenForm.cs KODLARI
---------------------------------------------------------
```csharp
using System;
using System.Windows.Forms;

namespace VirtualCatSimulator
{
    public partial class PetScreenForm : Form
    {
        // Kedi nesnesi burada tutulur
        private VirtualCat cat;

        public PetScreenForm()
        {
            InitializeComponent();

            // Tekir adlı bir kedi oluşturulur
            cat = new VirtualCat("Tekir");

            // Timer ayarları
            timerStats.Interval = 1000;   // Her 1 saniyede bir tetiklenecek
            timerStats.Start();          // Timer başlatılır

            // İlk değerlerin ekrana basılması
            UpdateBars();
            UpdateCatImage();
        }

        // ProgressBar değerlerini günceller
        private void UpdateBars()
        {
            progressHunger.Value = cat.Hunger;
            progressEnergy.Value = cat.Energy;
            progressPlay.Value = cat.Playfulness;
        }

        // Kedinin hangi resmin gösterileceğini belirler
        private void UpdateCatImage()
        {
            if (cat.Hunger < 30 || cat.Energy < 30 || cat.Playfulness < 30)
            {
                pictureBoxCat.Image = Properties.Resources.sad_cat; // Üzgün kedi
            }
            else
            {
                pictureBoxCat.Image = Properties.Resources.happy_cat; // Mutlu kedi
            }
        }

        // Her saniye çalışan timer statları azaltır
        private void timerStats_Tick(object sender, EventArgs e)
        {
            cat.Tick();        // Kedi statları düşer
            UpdateBars();      // ProgressBar güncellenir
            UpdateCatImage();  // Görsel güncellenir
        }

        // Yemek butonuna basıldığında çalışır
        private void btnFeed_Click(object sender, EventArgs e)
        {
            cat.Feed();
            UpdateBars();
            UpdateCatImage();
        }

        // Uyutma butonuna basıldığında çalışır
        private void btnSleep_Click(object sender, EventArgs e)
        {
            cat.Sleep();
            UpdateBars();
            UpdateCatImage();
        }

        // Oynatma butonuna basıldığında çalışır
        private void btnPlay_Click(object sender, EventArgs e)
        {
            cat.Play();
            UpdateBars();
            UpdateCatImage();
        }

        // Geri dön butonu
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(); // Yeni ana menü formu açılır
            mainForm.Show();
            this.Close(); // Bu form kapatılır
        }
    }
}
```
---------------------------------------------------------
5. Form1 (ANA MENÜ) OLUŞTURMA
---------------------------------------------------------

Form1 üzerine iki buton ekleyin:
- btnStart
- btnExit

---------------------------------------------------------
6. Form1.cs KODLARI
---------------------------------------------------------
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualCatSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // START butonu tıklanınca oyun ekranı açılır
        private void btnStart_Click(object sender, EventArgs e)
        {
            PetScreenForm petForm = new PetScreenForm(); // Kedi ekranı oluşturulur
            petForm.Show();   // Kedi ekranı açılır
            this.Hide();      // Ana menü gizlenir
        }

        // EXIT butonu tıklanınca uygulama kapanır
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
```
---------------------------------------------------------
7. UYGULAMAYI ÇALIŞTIR
---------------------------------------------------------

- Form1 başlangıç formu olmalı
- START → kedi ekranı açılır
- Feed, Sleep, Play → stat yükseltir
- Timer → statları azaltır
- Stat < 30 → kedi üzgün görünür
- Back → Form1’e döner
- Exit → uygulamayı kapatır

---------------------------------------------------------
TAMAMLANDI
---------------------------------------------------------
Bu çalışmada OOP, Windows Forms, Timer mantığı ve Form geçişlerini uygulamalı olarak öğrendiniz.

