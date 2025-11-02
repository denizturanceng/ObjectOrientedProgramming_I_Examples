namespace Cv_Maker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxTCID = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewRecords = new System.Windows.Forms.ListView();
            this.gBKisiselBilgiler.SuspendLayout();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBKisiselBilgiler
            // 
            this.gBKisiselBilgiler.Controls.Add(this.textBoxEmail);
            this.gBKisiselBilgiler.Controls.Add(this.label7);
            this.gBKisiselBilgiler.Controls.Add(this.comboBoxCities);
            this.gBKisiselBilgiler.Controls.Add(this.label6);
            this.gBKisiselBilgiler.Controls.Add(this.label5);
            this.gBKisiselBilgiler.Controls.Add(this.radioButtonFemale);
            this.gBKisiselBilgiler.Controls.Add(this.radioButtonMale);
            this.gBKisiselBilgiler.Controls.Add(this.maskedTextBoxTCID);
            this.gBKisiselBilgiler.Controls.Add(this.label4);
            this.gBKisiselBilgiler.Controls.Add(this.maskedTextBoxTelephoneNumber);
            this.gBKisiselBilgiler.Controls.Add(this.label3);
            this.gBKisiselBilgiler.Controls.Add(this.maskedTextBoxBirthDate);
            this.gBKisiselBilgiler.Controls.Add(this.label2);
            this.gBKisiselBilgiler.Controls.Add(this.textBoxNameSurname);
            this.gBKisiselBilgiler.Controls.Add(this.label1);
            this.gBKisiselBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBKisiselBilgiler.Location = new System.Drawing.Point(12, 26);
            this.gBKisiselBilgiler.Name = "gBKisiselBilgiler";
            this.gBKisiselBilgiler.Size = new System.Drawing.Size(452, 358);
            this.gBKisiselBilgiler.TabIndex = 0;
            this.gBKisiselBilgiler.TabStop = false;
            this.gBKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(205, 136);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(211, 30);
            this.textBoxEmail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "E-Posta";
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Amasya",
            "Ankara",
            "İstanbul",
            "İzmir",
            "Bursa"});
            this.comboBoxCities.Location = new System.Drawing.Point(205, 316);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(211, 33);
            this.comboBoxCities.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "İkametgah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cinsiyet";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(351, 271);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(81, 29);
            this.radioButtonFemale.TabIndex = 10;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Kadın";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(205, 271);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(80, 29);
            this.radioButtonMale.TabIndex = 9;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Erkek";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxTCID
            // 
            this.maskedTextBoxTCID.Location = new System.Drawing.Point(205, 225);
            this.maskedTextBoxTCID.Mask = "00000000000";
            this.maskedTextBoxTCID.Name = "maskedTextBoxTCID";
            this.maskedTextBoxTCID.Size = new System.Drawing.Size(211, 30);
            this.maskedTextBoxTCID.TabIndex = 8;
            this.maskedTextBoxTCID.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC Kimlik Numarası";
            // 
            // maskedTextBoxTelephoneNumber
            // 
            this.maskedTextBoxTelephoneNumber.Location = new System.Drawing.Point(205, 173);
            this.maskedTextBoxTelephoneNumber.Mask = "+00 (000) 000 00 00";
            this.maskedTextBoxTelephoneNumber.Name = "maskedTextBoxTelephoneNumber";
            this.maskedTextBoxTelephoneNumber.Size = new System.Drawing.Size(211, 30);
            this.maskedTextBoxTelephoneNumber.TabIndex = 6;
            this.maskedTextBoxTelephoneNumber.Text = "90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon Numarası";
            // 
            // maskedTextBoxBirthDate
            // 
            this.maskedTextBoxBirthDate.Location = new System.Drawing.Point(205, 94);
            this.maskedTextBoxBirthDate.Mask = "00/00/0000";
            this.maskedTextBoxBirthDate.Name = "maskedTextBoxBirthDate";
            this.maskedTextBoxBirthDate.Size = new System.Drawing.Size(211, 30);
            this.maskedTextBoxBirthDate.TabIndex = 4;
            this.maskedTextBoxBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğum Tarihi";
            // 
            // textBoxNameSurname
            // 
            this.textBoxNameSurname.Location = new System.Drawing.Point(205, 45);
            this.textBoxNameSurname.Name = "textBoxNameSurname";
            this.textBoxNameSurname.Size = new System.Drawing.Size(211, 30);
            this.textBoxNameSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(488, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(372, 51);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.listViewRecords);
            this.gbList.Controls.Add(this.listView1);
            this.gbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbList.Location = new System.Drawing.Point(12, 410);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(848, 402);
            this.gbList.TabIndex = 14;
            this.gbList.TabStop = false;
            this.gbList.Text = "Kayıtlar";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear.Location = new System.Drawing.Point(488, 251);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(372, 51);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Temizle";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(156, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(8, 8);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listViewRecords
            // 
            this.listViewRecords.HideSelection = false;
            this.listViewRecords.Location = new System.Drawing.Point(14, 29);
            this.listViewRecords.Name = "listViewRecords";
            this.listViewRecords.Size = new System.Drawing.Size(834, 367);
            this.listViewRecords.TabIndex = 2;
            this.listViewRecords.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 836);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gBKisiselBilgiler);
            this.Name = "Form1";
            this.Text = "CV Oluşturcu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBKisiselBilgiler.ResumeLayout(false);
            this.gBKisiselBilgiler.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBKisiselBilgiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameSurname;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTCID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListView listViewRecords;
        private System.Windows.Forms.ListView listView1;
    }
}

