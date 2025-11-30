# Virtual Cat Simulator – C# WinForms DIY Lab

Bu DIY (Do It Yourself) laboratuvar çalışmasında C# Windows Forms ve Nesneye Yönelik Programlama (OOP) tekniklerini kullanarak basit bir Sanal Kedi Simülatörü geliştireceksiniz.

---------------------------------------------------------
0. PROJE OLUŞTURMA
---------------------------------------------------------
1. Visual Studio → File → New → Project
2. “Windows Forms App (.NET Framework)” seçin
3. Proje adı: VirtualCatSimulator
4. Oluşturun


---------------------------------------------------------
1. VirtualCat.cs (OOP Sınıf Tasarımı)
---------------------------------------------------------

Solution Explorer → Add → Class → VirtualCat.cs

Kodları:

using System;

namespace VirtualCatSimulator
{
    public class VirtualCat
    {
        private string _name;
        private int _hunger;
        private int _energy;
        private int _playfulness;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Hunger => _hunger;
        public int Energy => _energy;
        public int Playfulness => _playfulness;

        public VirtualCat(string name)
        {
            _name = name;
            _hunger = 80;        
            _energy = 80;        
            _playfulness = 80;   
        }

        public void Feed()
        {
            _hunger = Math.Min(100, _hunger + 20);
        }

        public void Play()
        {
            _playfulness = Math.Min(100, _playfulness + 20);
        }

        public void Sleep()
        {
            _energy = Math.Min(100, _energy + 25);
        }

        public void Tick()
        {
            _hunger = Math.Max(0, _hunger - 5);
            _energy = Math.Max(0, _energy - 3);
            _playfulness = Math.Max(0, _playfulness - 4);
        }
    }
}


---------------------------------------------------------
2. KEDİ GÖRSELLERİNİ EKLEYİN
---------------------------------------------------------

1. Solution Explorer → Properties
2. Resources sekmesi
3. Add Resource → Add Existing File
   - happy_cat.png
   - sad_cat.png

Kodda şu şekilde kullanılır:
Properties.Resources.happy_cat
Properties.Resources.sad_cat


---------------------------------------------------------
3. PetScreenForm OLUŞTURMA
---------------------------------------------------------

Solution Explorer → Add → Windows Form → PetScreenForm.cs

Bu form üzerine şunları ekleyin:

PictureBox → pictureBoxCat  
ProgressBar → progressHunger  
ProgressBar → progressEnergy  
ProgressBar → progressPlay  
Button → btnFeed  
Button → btnSleep  
Button → btnPlay  
Button → btnBack  
Timer → timerStats (Interval: 3000)


---------------------------------------------------------
4. PetScreenForm.cs KODLARI
---------------------------------------------------------

using System;
using System.Windows.Forms;

namespace VirtualCatSimulator
{
    public partial class PetScreenForm : Form
    {
        private VirtualCat cat;

        public PetScreenForm()
        {
            InitializeComponent();

            cat = new VirtualCat("Tekir");

            timerStats.Interval = 3000; 
            timerStats.Start();

            UpdateBars();
            UpdateCatImage();
        }

        private void UpdateBars()
        {
            progressHunger.Value = cat.Hunger;
            progressEnergy.Value = cat.Energy;
            progressPlay.Value = cat.Playfulness;
        }

        private void UpdateCatImage()
        {
            if (cat.Hunger < 30 || cat.Energy < 30 || cat.Playfulness < 30)
                pictureBoxCat.Image = Properties.Resources.sad_cat;
            else
                pictureBoxCat.Image = Properties.Resources.happy_cat;
        }

        private void timerStats_Tick(object sender, EventArgs e)
        {
            cat.Tick();
            UpdateBars();
            UpdateCatImage();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            cat.Feed();
            UpdateBars();
            UpdateCatImage();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            cat.Sleep();
            UpdateBars();
            UpdateCatImage();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            cat.Play();
            UpdateBars();
            UpdateCatImage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}


---------------------------------------------------------
5. Form1 (ANA MENÜ)
---------------------------------------------------------

Form1’e iki buton ekleyin:
- btnStart
- btnExit


---------------------------------------------------------
6. Form1.cs KODLARI
---------------------------------------------------------

using System;
using System.Windows.Forms;

namespace VirtualCatSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PetScreenForm petForm = new PetScreenForm();
            petForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


---------------------------------------------------------
7. ÇALIŞTIRIN
---------------------------------------------------------

- Form1 başlangıç formu olsun
- Start → kedi ekranı açılır
- Feed / Sleep / Play → stat yükseltir
- Timer → statları düşürür
- Stat < 30 → üzgün kedi
- Back → ana menüye dönüş
- Exit → uygulamayı kapatır


---------------------------------------------------------
TAMAMLANDI!
---------------------------------------------------------
Bu lab ile:
OOP – Encapsulation – Constructor – WinForms – Timer – Form navigation
konularını tamamlamış oldunuz.

