using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MachineLearningForKids.Forms
{
    public partial class frmRockPaperScissors : Form
    {
        private MLContext mlContext;
        private GenerateModel generateModel;
        private Prediction prediction;
        private string pcResult;
        public frmRockPaperScissors()
        {
            InitializeComponent();
        }
        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
            AygitYukle();
        }
        private FilterInfoCollection goruntuAygitlari;
        private VideoCaptureDevice kameramiz;
        private void kameramiz_NewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap bit = (Bitmap)e.Frame.Clone();
            imgGiris.Image = bit;
        }
        public void AygitYukle()
        {
            goruntuAygitlari = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo aygit in goruntuAygitlari)
            {
                comboBox1.Items.Add(aygit);
            }
            comboBox1.SelectedIndex = 0;
            kameramiz = new VideoCaptureDevice(goruntuAygitlari[comboBox1.SelectedIndex].MonikerString);
            kameramiz.NewFrame += new NewFrameEventHandler(kameramiz_NewFrame);
            kameramiz.Start();
        }
        public void Predict(MLContext mLContext, ITransformer model)
        {

            prediction = new Prediction();
            string _predictSingleImage = Application.StartupPath + "\\images\\predict.jpg";
            List<string> result = prediction.ClassifySingleImage(mlContext, model, _predictSingleImage);

            if (pcResult == "tas")
            {
                if (result[0] == "tas")
                {
                    lblDurum.Text = "Berabere!";
                }
                else if (result[0] == "kagit")
                {
                    lblDurum.Text = "Kazandınız!";
                }
                else
                {
                    lblDurum.Text = "Kaybettiniz!!";
                }
            }
            if (pcResult == "kagit")
            {
                if (result[0] == "kagit")
                {
                    lblDurum.Text = "Berabere!";
                }
                else if (result[0] == "makas")
                {
                    lblDurum.Text = "Kazandınız!";
                }
                else
                {
                    lblDurum.Text = "Kaybettiniz!";
                }
            }
            if (pcResult == "makas")
            {
                if (result[0] == "makas")
                {
                    lblDurum.Text = "Berabere!";
                }
                else if (result[0] == "tas")
                {
                    lblDurum.Text = "Kazandınız!";
                }
                else
                {
                    lblDurum.Text = "Kaybettiniz!";
                }
            }
            lblSonuc.Text = result[0]; // Tahmin Sonucu
            lblScore.Text = result[1]; // Başarım Oranı
            lblDurum.Visible = true;
            lblScore.Visible = true;
            lblSonuc.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

        }
        private void btnPredict_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 4);
            if (sayi == 1)
            {
                imgBilgisayar.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\tasBilgisayar.png");
                pcResult = "tas";
            }
            if (sayi == 2)
            {
                imgBilgisayar.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\kagitBilgisayar.png");
                pcResult = "kagit";
            }
            if (sayi == 3)
            {
                imgBilgisayar.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\makasBilgisayar.png");
                pcResult = "makas";
            }
            imgTahmin.Image.Save(Application.StartupPath + "\\images\\predict.jpg");
            Result();
        }
        public void Result()
        {
            string dataName = "./data/rockpaperscissors.csv";
            generateModel = new GenerateModel();
            mlContext = new MLContext();
            var model = generateModel.TrainModel(mlContext, dataName);
            Predict(mlContext, model);
        }
        private void btnFotoğrafCek_Click(object sender, EventArgs e)
        {
            imgTahmin.Image = imgGiris.Image;
            btnPredict.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            kameramiz.Stop();
        }
    }
}
