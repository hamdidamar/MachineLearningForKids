using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids.Forms
{
    public partial class frmXOX : Form
    {
        public frmXOX()
        {
            InitializeComponent();
        }
        public static string gonderilecek_ad1, gonderilecek_ad2, gonderilecek_ip, gonderilecek_secim;
        public static int gonderilecek_zorluk;
        //Diğer formlara gönderilecek bilgiler
        private void rdo_ikikisilik_CheckedChanged(object sender, EventArgs e)
        {
            //İki kişilik seçeneği seçilirse diğer seçenekte kullanılacakların görünürlüğü kapatılıyor.
            lbl_oyuncuadi2.Visible = true;
            txtbx_oyuncuadi2.Visible = true;
            lbl_oyuncuadi1.Visible = true;
            txtbx_oyuncuadi1.Visible = true;
            groupBox2.Visible = false;
            groupBox2.Visible = false;
        }

        private void rdo_pckarsi_CheckedChanged(object sender, EventArgs e)
        {
            //Eğer bilgisayara karşı seçeneği seçilirse diğer seçenekte kullanılacakların görünürlüğü kapatılıyor.
            lbl_oyuncuadi2.Visible = false;
            txtbx_oyuncuadi2.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void rdo_lan_CheckedChanged(object sender, EventArgs e)
        {
            //Eğer Yerel Ağdan oynama seçeneği seçilirse diğer seçenekte kullanılacakların görünürlüğü kapatılıyor.
            rdo_X.Checked = true;
            lbl_oyuncuadi2.Visible = false;
            txtbx_oyuncuadi2.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            txtbx_Ip.Text = GetLocalIP();//Bilgisayarın IP'si alınıyor.
            gonderilecek_ip = txtbx_Ip.Text;//TextBoxtaki ip gönderilmesi için bir değişkende tutuluyor.


            //Oyuncular hangi harfi isterlerse ona göre köprü değeri ataması yapılıyor.
            if (rdo_X.Checked == true) { txtbx_Port.Text = "2"; gonderilecek_secim = txtbx_Port.Text; }//Hata çıkmasın diye yapılan en baştaki atamalar.
            else if (rdo_O.Checked == true) { txtbx_Port.Text = "1"; gonderilecek_secim = txtbx_Port.Text; }
            else { MessageBox.Show("Burada Hata Var!"); Close(); }
        }

        private void frmXOX_Load(object sender, EventArgs e)
        {
            //En başta 3 seçenek olsun diye.
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            lbl_oyuncuadi1.Visible = false;
            lbl_oyuncuadi2.Visible = false;
            txtbx_oyuncuadi1.Visible = false;
            txtbx_oyuncuadi2.Visible = false;
        }

        private void rdo_X_CheckedChanged(object sender, EventArgs e)
        {
            txtbx_Port.Text = "2"; gonderilecek_secim = txtbx_Port.Text;
            //Eğer X seçeneği seçilirse köprü değeri 2
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdo_O_CheckedChanged(object sender, EventArgs e)
        {
            txtbx_Port.Text = "1"; gonderilecek_secim = txtbx_Port.Text;
            //Eğer O seçeneği seçilirse köprü değeri 1
        }

        private void buton_oyna_Click(object sender, EventArgs e)
        {
            //Oyna butonuna basılırsa:
            if (rdo_ikikisilik.Checked == true)
            {
                //Eğer iki kişilik seçeneği seçildiğinde:
                //1.oyuncu adı ve 2.oyuncu adı gönderiliyor.
                gonderilecek_ad1 = txtbx_oyuncuadi1.Text;
                gonderilecek_ad2 = txtbx_oyuncuadi2.Text;


                UIHumanVsHuman iki_kisilik = new UIHumanVsHuman();

                iki_kisilik.Visible = false;//Form'un görünürlüğü kapatılıp sonra açılacak.
                iki_kisilik.Show();//Form penceresi açılıyor.
                //ShowDialog
            }

            else if (rdo_pckarsi.Checked == true)
            {   //Eğer bilgisayara karşı seçilirse 1.oyuncu adı gönderiliyor.
                gonderilecek_ad1 = txtbx_oyuncuadi1.Text;
                //Seçilecek zorluk seviyesine göre seviye ataması yapılıyor.
                if (rdo_kolay.Checked == true) { gonderilecek_zorluk = 55; }
                else if (rdo_orta.Checked == true) { gonderilecek_zorluk = 75; }
                else if (rdo_zor.Checked == true) { gonderilecek_zorluk = 95; }
                else { MessageBox.Show("BURADA BİR HATA VAR", "Hata Penceresi", MessageBoxButtons.OK); }




                UIHumanVsAI pc_karsi = new UIHumanVsAI();

                pc_karsi.Visible = false;

                pc_karsi.Show();
            }

            else if (rdo_lan.Checked == true)
            {

                FormSunucuEklenti lan_karsi = new FormSunucuEklenti();
                lan_karsi.Visible = false;
                lan_karsi.Show();
            }
        }
        private string GetLocalIP()
        {   //Kullanıcı I.P adresini de görebilsin diye yapılan bir düzenleme
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";//Eğer bulunamazsa bu değer atanıyor.
        }
    }
}
