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
    public partial class frmLessons : Form
    {
        public frmLessons()
        {
            InitializeComponent();
        }
        int ogrenciSayisi=0;
        int anlikOgrenci=0;
        int matematikPuan = 0;
        int turkcePuan = 0;
        int fenPuan = 0;
        int resimPuan = 0;
        int bedenPuan = 0;
        int cografyaPuan = 0;
        int muzikPuan = 0;
        int dersSayac = 1;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            ogrenciSayisi = int.Parse(txtOgrenciSayi.Value.ToString());
            if (ogrenciSayisi<=1)
            {
                MessageBox.Show("Lüften Birden Çok Öğrenci Sayısı Giriniz.!"); ;
            }
            else
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\matematik.png");
                lblDersAd.Text = "MATEMATİK";
                imgDers.Visible = true;
                rdoSevmiyorum.Visible = true;
                rdoOrta.Visible = true;
                rdoSeviyorum.Visible = true;
                btnGonder.Visible = true;
                lblDersAd.Visible = true;

                lblOgrenciSayi.Visible = false;
                txtOgrenciSayi.Visible = false;
                btnBasla.Visible = false;
            }
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (dersSayac == 8)
            {
                dersSayac = 1;
            }
            if (dersSayac ==1)
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\turkce.jpg");
                lblDersAd.Text = "TÜRKÇE";
            }
            if (dersSayac ==2)
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\fenbilgisi.jpg");
                lblDersAd.Text = "FEN BİLGİSİ";
            }
            if (dersSayac ==3)
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\resim.jpg");
                lblDersAd.Text = "RESİM";
            }
            if (dersSayac ==4)
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\beden.jpg");
                lblDersAd.Text = "BEDEN EĞİTİMİ";
            }
            if (dersSayac ==5)
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\cografya.jpg");
                lblDersAd.Text = "COĞRAFYA";
            }
            if (dersSayac ==6)
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\muzik.jpg");
                lblDersAd.Text = "MÜZİK";
            }
            if (dersSayac ==7)
            {
                imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\matematik.png");
                lblDersAd.Text = "MATEMATİK";
            }      
            if (anlikOgrenci<ogrenciSayisi)
            {
                if (rdoOrta.Checked)
                {
                    if (dersSayac == 1)
                    {
                        matematikPuan += 10;
                    }
                    if (dersSayac == 2)
                    {
                        turkcePuan += 10;
                    }
                    if (dersSayac == 3)
                    {
                        fenPuan += 10;
                    }
                    if (dersSayac == 4)
                    {
                        resimPuan += 10;
                    }
                    if (dersSayac == 5)
                    {
                        bedenPuan += 10;
                    }
                    if (dersSayac == 6)
                    {
                        cografyaPuan += 10;
                    }
                    if (dersSayac == 7)
                    {
                        muzikPuan += 10;
                        anlikOgrenci++;
                        MessageBox.Show(anlikOgrenci+". Öğrenci Bitti");
                    }
                    dersSayac++;
                }
                if (rdoSeviyorum.Checked)
                {
                    if (dersSayac == 1)
                    {
                        matematikPuan += 20;
                    }
                    if (dersSayac == 2)
                    {
                        turkcePuan += 20;
                    }
                    if (dersSayac == 3)
                    {
                        fenPuan += 20;
                    }
                    if (dersSayac == 4)
                    {
                        resimPuan += 20;
                    }
                    if (dersSayac == 5)
                    {
                        bedenPuan += 20;
                    }
                    if (dersSayac == 6)
                    {
                        cografyaPuan += 20;
                    }
                    if (dersSayac == 7)
                    {
                        muzikPuan += 20;
                        anlikOgrenci++;
                        MessageBox.Show("Öğrenci Bitti",anlikOgrenci.ToString());
                    }
                    dersSayac++;
                }
                if (rdoSevmiyorum.Checked)
                {
                    if (dersSayac == 7)
                    {
                        anlikOgrenci++;
                        MessageBox.Show("Öğrenci Bitti", anlikOgrenci.ToString());
                    }
                    dersSayac++;
                }
                if(rdoOrta.Checked == false && rdoSevmiyorum.Checked == false && rdoSeviyorum.Checked == false)
                {
                    imgDers.Image = Image.FromFile(@"E:\ProjeYonetimi\MachineLearningForKids\MachineLearningForKids\images\matematik.png");
                    lblDersAd.Text = "MATEMATİK";
                    MessageBox.Show("Herhangi Bir Değer Girmediniz..!");
                }
                
            }
            if (anlikOgrenci==ogrenciSayisi)
            {
                lblMatematikPuan.Text = matematikPuan.ToString() +" PUAN";
                lblTurkcePuan.Text = turkcePuan.ToString() + " PUAN";
                lblFenPuan.Text = fenPuan.ToString() + " PUAN";
                lblResimPuan.Text = resimPuan.ToString() + " PUAN";
                lblBedenPuan.Text = bedenPuan.ToString() + " PUAN";
                lblCografyaPuan.Text = cografyaPuan.ToString() + " PUAN";
                lblMuzikPuan.Text = muzikPuan.ToString() + " PUAN";


                lblMatematikPuan.Visible = true;
                lblTurkcePuan.Visible = true;
                lblFenPuan.Visible = true;
                lblResimPuan.Visible = true;
                lblBedenPuan.Visible = true;
                lblCografyaPuan.Visible = true;
                lblMuzikPuan.Visible = true;

                lblSonuclar.Visible = true;
                lblMatematik.Visible = true;
                lblTurkce.Visible = true;
                lblFen.Visible = true;
                lblResim.Visible = true;
                lblBeden.Visible = true;
                lblCografya.Visible = true;
                lblMuzik.Visible = true;

                btnTekrar.Visible = true;
            }
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            frmLessons lessons = new frmLessons();
            lessons.ShowDialog();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
