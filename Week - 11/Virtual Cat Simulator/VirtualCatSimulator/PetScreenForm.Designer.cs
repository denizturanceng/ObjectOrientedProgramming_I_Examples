namespace VirtualCatSimulator
{
    partial class PetScreenForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxCat = new System.Windows.Forms.PictureBox();
            this.lblHunger = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.progressHunger = new System.Windows.Forms.ProgressBar();
            this.progressEnergy = new System.Windows.Forms.ProgressBar();
            this.progressPlay = new System.Windows.Forms.ProgressBar();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timerStats = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCat
            // 
            this.pictureBoxCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCat.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCat.Name = "pictureBoxCat";
            this.pictureBoxCat.Size = new System.Drawing.Size(784, 241);
            this.pictureBoxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCat.TabIndex = 0;
            this.pictureBoxCat.TabStop = false;
            // 
            // lblHunger
            // 
            this.lblHunger.AutoSize = true;
            this.lblHunger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHunger.Location = new System.Drawing.Point(94, 266);
            this.lblHunger.Name = "lblHunger";
            this.lblHunger.Size = new System.Drawing.Size(74, 24);
            this.lblHunger.TabIndex = 1;
            this.lblHunger.Text = "Hunger";
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnergy.Location = new System.Drawing.Point(355, 266);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(71, 24);
            this.lblEnergy.TabIndex = 2;
            this.lblEnergy.Text = "Energy";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlay.Location = new System.Drawing.Point(607, 266);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(104, 24);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "Playfulness";
            // 
            // progressHunger
            // 
            this.progressHunger.Location = new System.Drawing.Point(16, 310);
            this.progressHunger.Name = "progressHunger";
            this.progressHunger.Size = new System.Drawing.Size(229, 23);
            this.progressHunger.TabIndex = 4;
            this.progressHunger.Value = 70;
            // 
            // progressEnergy
            // 
            this.progressEnergy.Location = new System.Drawing.Point(280, 310);
            this.progressEnergy.Name = "progressEnergy";
            this.progressEnergy.Size = new System.Drawing.Size(229, 23);
            this.progressEnergy.TabIndex = 5;
            this.progressEnergy.Value = 70;
            // 
            // progressPlay
            // 
            this.progressPlay.Location = new System.Drawing.Point(544, 310);
            this.progressPlay.Name = "progressPlay";
            this.progressPlay.Size = new System.Drawing.Size(229, 23);
            this.progressPlay.TabIndex = 6;
            this.progressPlay.Value = 70;
            // 
            // btnFeed
            // 
            this.btnFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFeed.Location = new System.Drawing.Point(77, 339);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(108, 40);
            this.btnFeed.TabIndex = 7;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSleep.Location = new System.Drawing.Point(339, 339);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(108, 40);
            this.btnSleep.TabIndex = 8;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlay.Location = new System.Drawing.Point(603, 339);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 40);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timerStats
            // 
            this.timerStats.Interval = 3000;
            this.timerStats.Tick += new System.EventHandler(this.timerStats_Tick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(339, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PetScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.progressPlay);
            this.Controls.Add(this.progressEnergy);
            this.Controls.Add(this.progressHunger);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.lblHunger);
            this.Controls.Add(this.pictureBoxCat);
            this.Name = "PetScreenForm";
            this.Text = "Pet Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCat;
        private System.Windows.Forms.Label lblHunger;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.ProgressBar progressHunger;
        private System.Windows.Forms.ProgressBar progressEnergy;
        private System.Windows.Forms.ProgressBar progressPlay;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timerStats;
        private System.Windows.Forms.Button btnBack;
    }
}