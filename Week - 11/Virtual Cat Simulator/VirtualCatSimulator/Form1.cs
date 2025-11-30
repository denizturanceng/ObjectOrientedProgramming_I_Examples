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

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Oyunun olduğu formu nesne olarak çağırma
            PetScreenForm petForm = new PetScreenForm();

            petForm.Show(); // Kedili formu gösterme

            // Ana menüyü gizleme
            this.Hide();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatır.
        }
    }
}
