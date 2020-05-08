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
            this.imgGiris = new System.Windows.Forms.PictureBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imgTahmin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTahmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgGiris
            // 
            this.imgGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgGiris.Location = new System.Drawing.Point(0, 0);
            this.imgGiris.Name = "imgGiris";
            this.imgGiris.Size = new System.Drawing.Size(884, 250);
            this.imgGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGiris.TabIndex = 0;
            this.imgGiris.TabStop = false;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(171, 373);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 17;
            this.btnPredict.Text = "Tahmin";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(751, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Visible = false;
            // 
            // imgTahmin
            // 
            this.imgTahmin.Location = new System.Drawing.Point(736, 267);
            this.imgTahmin.Name = "imgTahmin";
            this.imgTahmin.Size = new System.Drawing.Size(136, 140);
            this.imgTahmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTahmin.TabIndex = 19;
            this.imgTahmin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgGiris);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 250);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.imgTahmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRockPaperScissors";
            this.Text = "frmRockPaperScissors";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTahmin)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}