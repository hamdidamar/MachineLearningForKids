namespace MachineLearningForKids.Forms
{
    partial class frmRockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockPaperScissors));
            this.imgGiris = new System.Windows.Forms.PictureBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imgTahmin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFotoğrafCek = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgBilgisayar = new System.Windows.Forms.PictureBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTahmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBilgisayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // imgGiris
            // 
            this.imgGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.imgGiris.Location = new System.Drawing.Point(3, 11);
            this.imgGiris.Name = "imgGiris";
            this.imgGiris.Size = new System.Drawing.Size(456, 317);
            this.imgGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGiris.TabIndex = 0;
            this.imgGiris.TabStop = false;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(3, 407);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(121, 23);
            this.btnPredict.TabIndex = 26;
            this.btnPredict.Text = "Tahmin";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Visible = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Visible = false;
            // 
            // imgTahmin
            // 
            this.imgTahmin.Location = new System.Drawing.Point(3, 331);
            this.imgTahmin.Name = "imgTahmin";
            this.imgTahmin.Size = new System.Drawing.Size(123, 96);
            this.imgTahmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTahmin.TabIndex = 19;
            this.imgTahmin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnFotoğrafCek);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.imgGiris);
            this.panel1.Controls.Add(this.imgTahmin);
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 436);
            this.panel1.TabIndex = 27;
            // 
            // btnFotoğrafCek
            // 
            this.btnFotoğrafCek.Location = new System.Drawing.Point(338, 410);
            this.btnFotoğrafCek.Name = "btnFotoğrafCek";
            this.btnFotoğrafCek.Size = new System.Drawing.Size(121, 23);
            this.btnFotoğrafCek.TabIndex = 25;
            this.btnFotoğrafCek.Text = "Fotoğraf Çek ";
            this.btnFotoğrafCek.UseVisualStyleBackColor = true;
            this.btnFotoğrafCek.Click += new System.EventHandler(this.btnFotoğrafCek_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kameraya Elinizi Gösterip Oyuna Başlayın Sonra \r\nTahmin Butonuna Basıp Bilgisayar" +
    "a Karşı Oynayın !";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(254, 355);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(97, 19);
            this.lblScore.TabIndex = 21;
            this.lblScore.Text = "Başarı Skoru";
            this.lblScore.Visible = false;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.White;
            this.lblSonuc.Location = new System.Drawing.Point(254, 336);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(52, 19);
            this.lblSonuc.TabIndex = 22;
            this.lblSonuc.Text = "Sonuç";
            this.lblSonuc.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.imgBilgisayar);
            this.panel2.Controls.Add(this.btnPredict);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.lblScore);
            this.panel2.Controls.Add(this.lblDurum);
            this.panel2.Controls.Add(this.lblSonuc);
            this.panel2.Location = new System.Drawing.Point(468, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 433);
            this.panel2.TabIndex = 28;
            // 
            // imgBilgisayar
            // 
            this.imgBilgisayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.imgBilgisayar.Image = ((System.Drawing.Image)(resources.GetObject("imgBilgisayar.Image")));
            this.imgBilgisayar.Location = new System.Drawing.Point(3, 11);
            this.imgBilgisayar.Name = "imgBilgisayar";
            this.imgBilgisayar.Size = new System.Drawing.Size(423, 317);
            this.imgBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBilgisayar.TabIndex = 0;
            this.imgBilgisayar.TabStop = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.White;
            this.lblDurum.Location = new System.Drawing.Point(196, 383);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(135, 19);
            this.lblDurum.TabIndex = 29;
            this.lblDurum.Text = "Kazanma Durumu";
            this.lblDurum.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(828, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(69, 53);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 30;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Başarı Skoru:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tahmin Sonucu:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(292, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "TAŞ-KAĞIT-MAKAS OYUNU";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRockPaperScissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRockPaperScissors";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTahmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBilgisayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgGiris;
        private System.Windows.Forms.Button btnPredict;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox imgTahmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFotoğrafCek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgBilgisayar;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}