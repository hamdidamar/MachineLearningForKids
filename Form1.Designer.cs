namespace MachineLearningForKids
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFaceRecognition = new System.Windows.Forms.Button();
            this.btnRockPaperScissors = new System.Windows.Forms.Button();
            this.btnCarOrCup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaceRecognition
            // 
            this.btnFaceRecognition.Location = new System.Drawing.Point(149, 131);
            this.btnFaceRecognition.Name = "btnFaceRecognition";
            this.btnFaceRecognition.Size = new System.Drawing.Size(75, 23);
            this.btnFaceRecognition.TabIndex = 0;
            this.btnFaceRecognition.Text = "Yüz Tanıma ";
            this.btnFaceRecognition.UseVisualStyleBackColor = true;
            this.btnFaceRecognition.Click += new System.EventHandler(this.btnFaceRecognition_Click);
            // 
            // btnRockPaperScissors
            // 
            this.btnRockPaperScissors.Location = new System.Drawing.Point(337, 131);
            this.btnRockPaperScissors.Name = "btnRockPaperScissors";
            this.btnRockPaperScissors.Size = new System.Drawing.Size(118, 23);
            this.btnRockPaperScissors.TabIndex = 1;
            this.btnRockPaperScissors.Text = "Taş Kağıt Makas";
            this.btnRockPaperScissors.UseVisualStyleBackColor = true;
            this.btnRockPaperScissors.Click += new System.EventHandler(this.btnRockPaperScissors_Click);
            // 
            // btnCarOrCup
            // 
            this.btnCarOrCup.Location = new System.Drawing.Point(507, 131);
            this.btnCarOrCup.Name = "btnCarOrCup";
            this.btnCarOrCup.Size = new System.Drawing.Size(133, 23);
            this.btnCarOrCup.TabIndex = 2;
            this.btnCarOrCup.Text = "Araba mı Kupa mı ?";
            this.btnCarOrCup.UseVisualStyleBackColor = true;
            this.btnCarOrCup.Click += new System.EventHandler(this.btnCarOrCup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarOrCup);
            this.Controls.Add(this.btnRockPaperScissors);
            this.Controls.Add(this.btnFaceRecognition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaceRecognition;
        private System.Windows.Forms.Button btnRockPaperScissors;
        private System.Windows.Forms.Button btnCarOrCup;
    }
}

