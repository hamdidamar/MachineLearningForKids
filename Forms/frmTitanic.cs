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
    public partial class frmTitanic : Form
    {
        public frmTitanic()
        {
            InitializeComponent();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (rdoKadin.Checked)
            {
                if(int.Parse(txtYas.Value.ToString()) > 0 && int.Parse(txtYas.Value.ToString()) <= 70 && int.Parse(txtBiletFiyat.Text) > 1000)
                {
                    if (cmbSinif.SelectedIndex == 0 || cmbSinif.SelectedIndex == 1 || cmbSinif.SelectedIndex == 2)
                    {
                        lblTahminSonuc.Text = "Tebrikler! Oyuncu Yaşıyor";
                        lblTahminSonuc.Visible = true;
                    }
                }
                else
                {
                    lblTahminSonuc.Text = "Maalesef :( Oyuncu Hayatta Kalamadı.!";
                    lblTahminSonuc.Visible = true;
                }
            }
            if (rdoErkek.Checked)
            {
                if(int.Parse(txtYas.Value.ToString()) > 0 && int.Parse(txtYas.Value.ToString()) <= 70 && int.Parse(txtBiletFiyat.Text) > 1000)
                {
                    if (cmbSinif.SelectedIndex == 0 || cmbSinif.SelectedIndex == 1)
                    {
                        lblTahminSonuc.Text = "Tebrikler! Oyuncu Yaşıyor!";
                        lblTahminSonuc.Visible = true;
                    }
                    else
                    {
                        lblTahminSonuc.Text = "Maalesef :( Oyuncu Hayatta Kalamadı.!";
                        lblTahminSonuc.Visible = true;
                    }
                }
                else
                {
                    lblTahminSonuc.Text = "Maalesef :( Oyuncu Hayatta Kalamadı.!";
                    lblTahminSonuc.Visible = true;
                }
            }
            else
            {
                if (!rdoKadin.Checked && !rdoErkek.Checked)
                {
                    lblTahminSonuc.Visible = false;
                    MessageBox.Show("Lütfen Cinsiyet Seçiniz..");
                }
                if(cmbSinif.Text==null || txtBiletFiyat.Text == null || txtYas.Value.ToString()==null)
                {
                    lblTahminSonuc.Visible = false;
                    MessageBox.Show("Lütfen Bütün Alanları Doldurun..");
                }

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
