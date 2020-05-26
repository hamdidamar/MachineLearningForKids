using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids.Forms
{
    public partial class frmPlayingCards : Form
    {
        private MLContext mlContext;
        private GenerateModel generateModel;
        private Prediction prediction;
        public frmPlayingCards()
        {
            InitializeComponent();
        }
        private void frmPlayinCards_Load(object sender, EventArgs e)
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
            List<string> result = new List<string>();
            result = prediction.ClassifySingleImage(mlContext, model, _predictSingleImage);

            lblSonuc.Text = result[0]; // Tahmin Sonucu
            lblScore.Text = result[1]; // Başarım Oranı
            lblScore.Visible = true;
            lblSonuc.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
        public void Result()
        {
            string dataName = "./data/playingcards.csv";
            generateModel = new GenerateModel();
            mlContext = new MLContext();
            var model = generateModel.TrainModel(mlContext, dataName);
            Predict(mlContext, model);
        }
        private void btnPredict_Click_1(object sender, EventArgs e)
        {
            imgTahmin.Image = imgGiris.Image;
            imgTahmin.Image.Save(Application.StartupPath + "\\images\\predict.jpg");
            Result();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
