using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids.Forms
{
    public partial class frmTrainTest : Form
    {
        public frmTrainTest()
        {
            InitializeComponent();
        }

        private void btnFotoğrafCek_Click(object sender, EventArgs e)
        {
            imgTahmin.Image = imgGiris.Image;
            btnFotoğrafCek.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSenaryolar.SelectedIndex == 0)
            {
                imgTahmin.Image.Save(Application.StartupPath + "\\images\\" + txtFotoName.Text + ".jpg");

                string fileName = @"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\data\faces.csv";

                string satir = "\n"+ txtFotoName.Text + ".jpg" + "," + txtEtiket.Text;

                File.AppendAllText(fileName, satir);
            }
            if (cmbSenaryolar.SelectedIndex == 1)
            {
                imgTahmin.Image.Save(Application.StartupPath + "\\images\\" + txtFotoName.Text + ".jpg");

                string fileName = @"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\data\rockpaperscissors.csv";

                string satir = "\n" + txtFotoName.Text + ".jpg" + "," + txtEtiket.Text;

                File.AppendAllText(fileName, satir);
            }
            if (cmbSenaryolar.SelectedIndex == 2)
            {
                imgTahmin.Image.Save(Application.StartupPath + "\\images\\" + txtFotoName.Text + ".jpg");

                string fileName = @"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\data\carsandcups.csv";

                string satir = "\n" + txtFotoName.Text + ".jpg" + "," + txtEtiket.Text;

                File.AppendAllText(fileName, satir);
            }
            if (cmbSenaryolar.SelectedIndex == 3)
            {
                imgTahmin.Image.Save(Application.StartupPath + "\\images\\" + txtFotoName.Text + ".jpg");

                string fileName = @"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\data\playingcards.csv";

                string satir = "\n" + txtFotoName.Text + ".jpg" + "," + txtEtiket.Text;

                File.AppendAllText(fileName, satir);
            }
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

        private void frmTrainTest_Load(object sender, EventArgs e)
        {
            AygitYukle();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            kameramiz.Stop();
        }
    }
}
