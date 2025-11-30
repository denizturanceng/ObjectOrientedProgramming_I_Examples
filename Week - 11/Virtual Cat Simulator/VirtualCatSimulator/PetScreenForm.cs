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

            // Kedi nesnesini oluştur
            cat = new VirtualCat("Tekir");

            // Timer ayarı
            timerStats.Interval = 1000; // 3 saniye
            timerStats.Start();

            // İlk değerleri göster
            UpdateBars();
            UpdateCatImage();
        }

        // ProgressBar’ları güncelleyen fonksiyon
        private void UpdateBars()
        {
            progressHunger.Value = cat.Hunger;
            progressEnergy.Value = cat.Energy;
            progressPlay.Value = cat.Playfulness;
        }

        // Kedinin mutlu/üzgün görselini belirleyen fonksiyon
        private void UpdateCatImage()
        {
            if (cat.Hunger < 30 || cat.Energy < 30 || cat.Playfulness < 30)
            {
                pictureBoxCat.Image = Properties.Resources.sad_cat;
            }
            else
            {
                pictureBoxCat.Image = Properties.Resources.happy_cat;
            }
        }

        // Timer her çalıştığında statların düşmesi
        private void timerStats_Tick(object sender, EventArgs e)
        {
            cat.Tick();
            UpdateBars();
            UpdateCatImage();
        }

        // YEMEK verme
        private void btnFeed_Click(object sender, EventArgs e)
        {
            cat.Feed();
            UpdateBars();
            UpdateCatImage();
        }

        // UYUTMA
        private void btnSleep_Click(object sender, EventArgs e)
        {
            cat.Sleep();
            UpdateBars();
            UpdateCatImage();
        }

        // OYNATMA
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
            this.Close(); // veya Hide() ama Close daha iyi
        }
    }
}
