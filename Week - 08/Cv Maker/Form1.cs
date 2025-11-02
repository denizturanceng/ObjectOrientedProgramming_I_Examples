using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cv_Maker
{


    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
        }


        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();

            yeniKisi.AdSoyad = textBoxNameSurname.Text.Trim();
            yeniKisi.DogumTarihi = maskedTextBoxBirthDate.Text.Trim();
            yeniKisi.Email = textBoxEmail.Text.Trim();
            yeniKisi.TcKimlik = maskedTextBoxTCID.Text.Trim();
            yeniKisi.Telefon = maskedTextBoxTelephoneNumber.Text.Trim();
            if (radioButtonMale.Checked) yeniKisi.Cinsiyet = "Erkek";
            else if (radioButtonFemale.Checked) yeniKisi.Cinsiyet = "Kadın";
            yeniKisi.Ikametgah = comboBoxCities.SelectedItem?.ToString();


            // Boş alan kontrolü

            if(
                string.IsNullOrWhiteSpace(yeniKisi.AdSoyad) ||
                string.IsNullOrWhiteSpace(yeniKisi.DogumTarihi) ||
                string.IsNullOrWhiteSpace(yeniKisi.Email) ||
                string.IsNullOrWhiteSpace(yeniKisi.Telefon) ||
                string.IsNullOrWhiteSpace(yeniKisi.TcKimlik) ||
                string.IsNullOrWhiteSpace(yeniKisi.Cinsiyet) ||
                string.IsNullOrWhiteSpace(yeniKisi.Ikametgah))      
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (!yeniKisi.Email.Contains("@") || !yeniKisi.Email.Contains("."))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin.", "Geçersiz E-Posta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (yeniKisi.TcKimlik.Length != 11 || !yeniKisi.TcKimlik.All(char.IsDigit))
                {
                    MessageBox.Show("Lütfen geçerli bir TC Kimlik numarası girin.", "Geçersiz TC Kimlik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (maskedTextBoxTelephoneNumber.MaskFull == false)
                {
                    MessageBox.Show("Lütfen geçerli bir telefon numarası girin.", "Geçersiz Telefon Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!maskedTextBoxBirthDate.MaskFull)
                {
                    MessageBox.Show("Lütfen geçerli bir doğum tarihi girin.", "Geçersiz Tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(yeniKisi.Cinsiyet != "Erkek" && yeniKisi.Cinsiyet != "Kadın")
                {
                    MessageBox.Show("Lütfen cinsiyet seçin.", "Geçersiz Cinsiyet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Bilgiler başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListViewItem item = new ListViewItem(yeniKisi.AdSoyad);
                item.SubItems.Add(yeniKisi.DogumTarihi);
                item.SubItems.Add(yeniKisi.Email);
                item.SubItems.Add(yeniKisi.Telefon);
                item.SubItems.Add(yeniKisi.Cinsiyet);
                item.SubItems.Add(yeniKisi.Ikametgah);

                listViewRecords.Items.Add(item);

                MessageBox.Show("Kayıt başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }

        }

        private void TemizleForm()
        {
            textBoxNameSurname.Clear();
            maskedTextBoxBirthDate.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelephoneNumber.Clear();
            maskedTextBoxTCID.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            comboBoxCities.SelectedIndex = -1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TemizleForm();
            listViewRecords.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewRecords.View = View.Details;
            listViewRecords.FullRowSelect = true;
            listViewRecords.GridLines = true;

            listViewRecords.Columns.Add("Ad Soyad", 120);
            listViewRecords.Columns.Add("Doğum Tarihi", 90);
            listViewRecords.Columns.Add("E-posta", 150);
            listViewRecords.Columns.Add("Telefon", 110);
            listViewRecords.Columns.Add("Cinsiyet", 70);
            listViewRecords.Columns.Add("İkametgah", 100);
        }

    }
}
