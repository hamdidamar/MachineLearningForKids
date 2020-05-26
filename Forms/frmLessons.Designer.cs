namespace MachineLearningForKids.Forms
{
    partial class frmLessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLessons));
            this.label5 = new System.Windows.Forms.Label();
            this.lblOgrenciSayi = new System.Windows.Forms.Label();
            this.txtOgrenciSayi = new System.Windows.Forms.NumericUpDown();
            this.btnBasla = new System.Windows.Forms.Button();
            this.imgDers = new System.Windows.Forms.PictureBox();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoSeviyorum = new System.Windows.Forms.RadioButton();
            this.rdoSevmiyorum = new System.Windows.Forms.RadioButton();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lblMatematik = new System.Windows.Forms.Label();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.lblFen = new System.Windows.Forms.Label();
            this.lblResim = new System.Windows.Forms.Label();
            this.lblBeden = new System.Windows.Forms.Label();
            this.lblMatematikPuan = new System.Windows.Forms.Label();
            this.lblTurkcePuan = new System.Windows.Forms.Label();
            this.lblFenPuan = new System.Windows.Forms.Label();
            this.lblResimPuan = new System.Windows.Forms.Label();
            this.lblBedenPuan = new System.Windows.Forms.Label();
            this.lblCografyaPuan = new System.Windows.Forms.Label();
            this.lblCografya = new System.Windows.Forms.Label();
            this.lblMuzikPuan = new System.Windows.Forms.Label();
            this.lblMuzik = new System.Windows.Forms.Label();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.lblSonuclar = new System.Windows.Forms.Label();
            this.btnTekrar = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "EN SEVİLEN DERS";
            // 
            // lblOgrenciSayi
            // 
            this.lblOgrenciSayi.AutoSize = true;
            this.lblOgrenciSayi.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciSayi.ForeColor = System.Drawing.Color.White;
            this.lblOgrenciSayi.Location = new System.Drawing.Point(28, 60);
            this.lblOgrenciSayi.Name = "lblOgrenciSayi";
            this.lblOgrenciSayi.Size = new System.Drawing.Size(169, 29);
            this.lblOgrenciSayi.TabIndex = 15;
            this.lblOgrenciSayi.Text = "Öğrenci Sayısı:";
            // 
            // txtOgrenciSayi
            // 
            this.txtOgrenciSayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOgrenciSayi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSayi.ForeColor = System.Drawing.Color.White;
            this.txtOgrenciSayi.Location = new System.Drawing.Point(203, 63);
            this.txtOgrenciSayi.Name = "txtOgrenciSayi";
            this.txtOgrenciSayi.Size = new System.Drawing.Size(140, 30);
            this.txtOgrenciSayi.TabIndex = 14;
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(359, 60);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(139, 36);
            this.btnBasla.TabIndex = 16;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // imgDers
            // 
            this.imgDers.Image = ((System.Drawing.Image)(resources.GetObject("imgDers.Image")));
            this.imgDers.Location = new System.Drawing.Point(33, 144);
            this.imgDers.Name = "imgDers";
            this.imgDers.Size = new System.Drawing.Size(474, 217);
            this.imgDers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDers.TabIndex = 17;
            this.imgDers.TabStop = false;
            this.imgDers.Visible = false;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoOrta.ForeColor = System.Drawing.Color.White;
            this.rdoOrta.Location = new System.Drawing.Point(227, 373);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(84, 27);
            this.rdoOrta.TabIndex = 19;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta :|";
            this.rdoOrta.UseVisualStyleBackColor = true;
            this.rdoOrta.Visible = false;
            // 
            // rdoSeviyorum
            // 
            this.rdoSeviyorum.AutoSize = true;
            this.rdoSeviyorum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoSeviyorum.ForeColor = System.Drawing.Color.White;
            this.rdoSeviyorum.Location = new System.Drawing.Point(372, 373);
            this.rdoSeviyorum.Name = "rdoSeviyorum";
            this.rdoSeviyorum.Size = new System.Drawing.Size(135, 27);
            this.rdoSeviyorum.TabIndex = 18;
            this.rdoSeviyorum.TabStop = true;
            this.rdoSeviyorum.Text = "Seviyorum :)";
            this.rdoSeviyorum.UseVisualStyleBackColor = true;
            this.rdoSeviyorum.Visible = false;
            // 
            // rdoSevmiyorum
            // 
            this.rdoSevmiyorum.AutoSize = true;
            this.rdoSevmiyorum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoSevmiyorum.ForeColor = System.Drawing.Color.White;
            this.rdoSevmiyorum.Location = new System.Drawing.Point(33, 373);
            this.rdoSevmiyorum.Name = "rdoSevmiyorum";
            this.rdoSevmiyorum.Size = new System.Drawing.Size(151, 27);
            this.rdoSevmiyorum.TabIndex = 20;
            this.rdoSevmiyorum.TabStop = true;
            this.rdoSevmiyorum.Text = "Sevmiyorum :(";
            this.rdoSevmiyorum.UseVisualStyleBackColor = true;
            this.rdoSevmiyorum.Visible = false;
            // 
            // btnGonder
            // 
            this.btnGonder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(203, 413);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(139, 36);
            this.btnGonder.TabIndex = 21;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Visible = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // lblMatematik
            // 
            this.lblMatematik.AutoSize = true;
            this.lblMatematik.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatematik.ForeColor = System.Drawing.Color.White;
            this.lblMatematik.Location = new System.Drawing.Point(604, 122);
            this.lblMatematik.Name = "lblMatematik";
            this.lblMatematik.Size = new System.Drawing.Size(132, 29);
            this.lblMatematik.TabIndex = 22;
            this.lblMatematik.Text = "Matematik:";
            this.lblMatematik.Visible = false;
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkce.ForeColor = System.Drawing.Color.White;
            this.lblTurkce.Location = new System.Drawing.Point(643, 164);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(93, 29);
            this.lblTurkce.TabIndex = 23;
            this.lblTurkce.Text = "Türkçe:";
            this.lblTurkce.Visible = false;
            // 
            // lblFen
            // 
            this.lblFen.AutoSize = true;
            this.lblFen.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFen.ForeColor = System.Drawing.Color.White;
            this.lblFen.Location = new System.Drawing.Point(610, 206);
            this.lblFen.Name = "lblFen";
            this.lblFen.Size = new System.Drawing.Size(126, 29);
            this.lblFen.TabIndex = 24;
            this.lblFen.Text = "Fen Bilgisi:";
            this.lblFen.Visible = false;
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResim.ForeColor = System.Drawing.Color.White;
            this.lblResim.Location = new System.Drawing.Point(651, 248);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(85, 29);
            this.lblResim.TabIndex = 25;
            this.lblResim.Text = "Resim:";
            this.lblResim.Visible = false;
            // 
            // lblBeden
            // 
            this.lblBeden.AutoSize = true;
            this.lblBeden.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeden.ForeColor = System.Drawing.Color.White;
            this.lblBeden.Location = new System.Drawing.Point(649, 290);
            this.lblBeden.Name = "lblBeden";
            this.lblBeden.Size = new System.Drawing.Size(87, 29);
            this.lblBeden.TabIndex = 26;
            this.lblBeden.Text = "Beden:";
            this.lblBeden.Visible = false;
            // 
            // lblMatematikPuan
            // 
            this.lblMatematikPuan.AutoSize = true;
            this.lblMatematikPuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatematikPuan.ForeColor = System.Drawing.Color.White;
            this.lblMatematikPuan.Location = new System.Drawing.Point(742, 122);
            this.lblMatematikPuan.Name = "lblMatematikPuan";
            this.lblMatematikPuan.Size = new System.Drawing.Size(39, 29);
            this.lblMatematikPuan.TabIndex = 27;
            this.lblMatematikPuan.Text = "00";
            this.lblMatematikPuan.Visible = false;
            // 
            // lblTurkcePuan
            // 
            this.lblTurkcePuan.AutoSize = true;
            this.lblTurkcePuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkcePuan.ForeColor = System.Drawing.Color.White;
            this.lblTurkcePuan.Location = new System.Drawing.Point(742, 164);
            this.lblTurkcePuan.Name = "lblTurkcePuan";
            this.lblTurkcePuan.Size = new System.Drawing.Size(39, 29);
            this.lblTurkcePuan.TabIndex = 28;
            this.lblTurkcePuan.Text = "00";
            this.lblTurkcePuan.Visible = false;
            // 
            // lblFenPuan
            // 
            this.lblFenPuan.AutoSize = true;
            this.lblFenPuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFenPuan.ForeColor = System.Drawing.Color.White;
            this.lblFenPuan.Location = new System.Drawing.Point(742, 206);
            this.lblFenPuan.Name = "lblFenPuan";
            this.lblFenPuan.Size = new System.Drawing.Size(39, 29);
            this.lblFenPuan.TabIndex = 29;
            this.lblFenPuan.Text = "00";
            this.lblFenPuan.Visible = false;
            // 
            // lblResimPuan
            // 
            this.lblResimPuan.AutoSize = true;
            this.lblResimPuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResimPuan.ForeColor = System.Drawing.Color.White;
            this.lblResimPuan.Location = new System.Drawing.Point(742, 248);
            this.lblResimPuan.Name = "lblResimPuan";
            this.lblResimPuan.Size = new System.Drawing.Size(39, 29);
            this.lblResimPuan.TabIndex = 30;
            this.lblResimPuan.Text = "00";
            this.lblResimPuan.Visible = false;
            // 
            // lblBedenPuan
            // 
            this.lblBedenPuan.AutoSize = true;
            this.lblBedenPuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBedenPuan.ForeColor = System.Drawing.Color.White;
            this.lblBedenPuan.Location = new System.Drawing.Point(742, 290);
            this.lblBedenPuan.Name = "lblBedenPuan";
            this.lblBedenPuan.Size = new System.Drawing.Size(39, 29);
            this.lblBedenPuan.TabIndex = 31;
            this.lblBedenPuan.Text = "00";
            this.lblBedenPuan.Visible = false;
            // 
            // lblCografyaPuan
            // 
            this.lblCografyaPuan.AutoSize = true;
            this.lblCografyaPuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCografyaPuan.ForeColor = System.Drawing.Color.White;
            this.lblCografyaPuan.Location = new System.Drawing.Point(742, 332);
            this.lblCografyaPuan.Name = "lblCografyaPuan";
            this.lblCografyaPuan.Size = new System.Drawing.Size(39, 29);
            this.lblCografyaPuan.TabIndex = 33;
            this.lblCografyaPuan.Text = "00";
            this.lblCografyaPuan.Visible = false;
            // 
            // lblCografya
            // 
            this.lblCografya.AutoSize = true;
            this.lblCografya.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCografya.ForeColor = System.Drawing.Color.White;
            this.lblCografya.Location = new System.Drawing.Point(620, 332);
            this.lblCografya.Name = "lblCografya";
            this.lblCografya.Size = new System.Drawing.Size(116, 29);
            this.lblCografya.TabIndex = 32;
            this.lblCografya.Text = "Coğrafya:";
            this.lblCografya.Visible = false;
            // 
            // lblMuzikPuan
            // 
            this.lblMuzikPuan.AutoSize = true;
            this.lblMuzikPuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuzikPuan.ForeColor = System.Drawing.Color.White;
            this.lblMuzikPuan.Location = new System.Drawing.Point(740, 374);
            this.lblMuzikPuan.Name = "lblMuzikPuan";
            this.lblMuzikPuan.Size = new System.Drawing.Size(39, 29);
            this.lblMuzikPuan.TabIndex = 35;
            this.lblMuzikPuan.Text = "00";
            this.lblMuzikPuan.Visible = false;
            // 
            // lblMuzik
            // 
            this.lblMuzik.AutoSize = true;
            this.lblMuzik.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuzik.ForeColor = System.Drawing.Color.White;
            this.lblMuzik.Location = new System.Drawing.Point(655, 374);
            this.lblMuzik.Name = "lblMuzik";
            this.lblMuzik.Size = new System.Drawing.Size(81, 29);
            this.lblMuzik.TabIndex = 34;
            this.lblMuzik.Text = "Müzik:";
            this.lblMuzik.Visible = false;
            // 
            // lblDersAd
            // 
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAd.ForeColor = System.Drawing.Color.White;
            this.lblDersAd.Location = new System.Drawing.Point(210, 112);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(117, 29);
            this.lblDersAd.TabIndex = 36;
            this.lblDersAd.Text = "DERS ADI";
            this.lblDersAd.Visible = false;
            // 
            // lblSonuclar
            // 
            this.lblSonuclar.AutoSize = true;
            this.lblSonuclar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuclar.ForeColor = System.Drawing.Color.White;
            this.lblSonuclar.Location = new System.Drawing.Point(672, 84);
            this.lblSonuclar.Name = "lblSonuclar";
            this.lblSonuclar.Size = new System.Drawing.Size(130, 29);
            this.lblSonuclar.TabIndex = 37;
            this.lblSonuclar.Text = "SONUÇLAR";
            this.lblSonuclar.Visible = false;
            // 
            // btnTekrar
            // 
            this.btnTekrar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekrar.Location = new System.Drawing.Point(634, 413);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(194, 36);
            this.btnTekrar.TabIndex = 38;
            this.btnTekrar.Text = "TEKRAR BAŞLA";
            this.btnTekrar.UseVisualStyleBackColor = true;
            this.btnTekrar.Visible = false;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(812, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(69, 53);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 39;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // frmLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.lblSonuclar);
            this.Controls.Add(this.lblDersAd);
            this.Controls.Add(this.lblMuzikPuan);
            this.Controls.Add(this.lblMuzik);
            this.Controls.Add(this.lblCografyaPuan);
            this.Controls.Add(this.lblCografya);
            this.Controls.Add(this.lblBedenPuan);
            this.Controls.Add(this.lblResimPuan);
            this.Controls.Add(this.lblFenPuan);
            this.Controls.Add(this.lblTurkcePuan);
            this.Controls.Add(this.lblMatematikPuan);
            this.Controls.Add(this.lblBeden);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.lblFen);
            this.Controls.Add(this.lblTurkce);
            this.Controls.Add(this.lblMatematik);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.rdoSevmiyorum);
            this.Controls.Add(this.rdoOrta);
            this.Controls.Add(this.rdoSeviyorum);
            this.Controls.Add(this.imgDers);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblOgrenciSayi);
            this.Controls.Add(this.txtOgrenciSayi);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLessons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLessons";
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOgrenciSayi;
        private System.Windows.Forms.NumericUpDown txtOgrenciSayi;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.PictureBox imgDers;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.RadioButton rdoSeviyorum;
        private System.Windows.Forms.RadioButton rdoSevmiyorum;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label lblMatematik;
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.Label lblFen;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label lblBeden;
        private System.Windows.Forms.Label lblMatematikPuan;
        private System.Windows.Forms.Label lblTurkcePuan;
        private System.Windows.Forms.Label lblFenPuan;
        private System.Windows.Forms.Label lblResimPuan;
        private System.Windows.Forms.Label lblBedenPuan;
        private System.Windows.Forms.Label lblCografyaPuan;
        private System.Windows.Forms.Label lblCografya;
        private System.Windows.Forms.Label lblMuzikPuan;
        private System.Windows.Forms.Label lblMuzik;
        private System.Windows.Forms.Label lblDersAd;
        private System.Windows.Forms.Label lblSonuclar;
        private System.Windows.Forms.Button btnTekrar;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}