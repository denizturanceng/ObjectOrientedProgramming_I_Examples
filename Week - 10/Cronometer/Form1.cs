using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre
{
    public partial class Form1 : Form
    {
        private TimeSpan time = TimeSpan.Zero;     // Geçen süreyi tutan değişken (00:00:00)

        private DateTime startTime;
        // Kronometrenin başladığı anı tutar. 
        // Burada neden "private DateTime startTime = new DateTime();" değil de sadece 
        // "private DateTime startTime;" kullandık?
        // Çünkü kronometrenin başlangıç zamanı her Start butonuna basıldığında 
        // DateTime.Now ile güncelleniyor. Eğer "new DateTime()" deseydik, değişken 
        // 01.01.0001 00:00:00 tarihine ayarlanırdı ve kronometrenin hesaplamaları 
        // yanlış olurdu. Bu yüzden başlangıç değerini otomatik vermiyoruz; 
        // gerçek başlangıç zamanını Start butonuna tıklanınca atıyoruz.


        private bool isStarted = false;            // Kronometre çalışıyor mu kontrolü için


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = "00:00:00";            // Program açıldığında sayaç sıfırdan başlasın
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Timer her tetiklendiğinde (Interval kadar) burası çalışır (yani her saniye tetikleniyor.)
            if (isStarted)
            {
                // Şu anki zaman - başlangıç zamanı = geçen süre
                time = DateTime.Now - startTime;

                // Tek haneli olan saat/dakika/saniyelerin başına "0" eklemek için formatlama
                string hours = time.Hours.ToString("00");
                string minutes = time.Minutes.ToString("00");
                string seconds = time.Seconds.ToString("00");

                // Label üzerinde süreyi göster
                lblSayac.Text = hours + ":" + minutes + ":" + seconds;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Kronometre şu an çalışmıyorsa başlat
            if (!isStarted)
            {
                isStarted = true;                  // Kronometre artık çalışıyor olarak işaretlenir

                // Eğer kronometre durdurulup tekrar başlatılırsa kaldığı yerden devam etsin
                startTime = DateTime.Now - time;

                timer.Start();                     // Timer başlatılır
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Kronometre şu anda çalışıyorsa durdur
            if (isStarted)
            {
                isStarted = false;                 // Kronometre durdu
                timer.Stop();                      // Timer durdurulur

                // Durdurulduğu ana kadar geçen süre hesaplanır
                // Stop’a bastığın anda kronometre durur.
                // O ana kadar geçen süreyi kaydetmen gerekir.
                // Bunu kaydetmezsen, Start’a tekrar basıldığında kaldığı yerden devam edemez.
                time = DateTime.Now - startTime;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Restart: süreyi sıfırla + ekrana sıfır yaz
            time = TimeSpan.Zero;                  // Süreyi baştan başlat
            startTime = DateTime.Now;              // Yeni başlangıç zamanı şimdi
            lblSayac.Text = "00:00:00";            // Ekranı sıfırla
            
        }

    }
}
