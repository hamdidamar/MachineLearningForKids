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
    public partial class FormSunucuEklenti : Form
    {
        public FormSunucuEklenti()
        {
            InitializeComponent();
        }

        Socket sck;//soket tanımlama
        EndPoint epLocal, epRemote;//İp bilgileri burada depolanıyor.
        byte[] buffer;
        string oyuncu_ip, oyuncu_port, oyuncu_harf, karsi_harf;//oyuncu adres bilgileri
        bool baslama_komutu = false;//diğer oyuncu bağlanmasını kontrol eden değer.

        private void buton_1_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_1.Text = oyuncu_harf.ToString();//Buton metni oyuncunun harfi oluyor.
                buton_1.Enabled = false;//Butona tıklanılma etkisiz hale getiriliyor.
                hamle_sayisi++;//Hamle sayısı arttırılıyor
                sure_sayma();//Süre sayma fonksiyonu çalıştırılıyor.
                kim_kazandi();//Kim kazandı kontrol ediliyor.
                oyun_sira++;//Oyunun sırası değiştiriliyor.
                ileti_Gonder(1);//Karşı tarafa 1 numaralı hamle yaptı diye mesaj gönderiliyor.
            }
        }

        private void buton_2_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_2.Text = oyuncu_harf.ToString();
                buton_2.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(2);
            }
        }

        private void buton_3_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_3.Text = oyuncu_harf.ToString();
                buton_3.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(3);
            }
        }

        private void buton_4_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_4.Text = oyuncu_harf.ToString();
                buton_4.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(4);
            }
        }

        private void buton_5_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_5.Text = oyuncu_harf.ToString();
                buton_5.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(5);
            }
        }

        private void buton_6_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_6.Text = oyuncu_harf.ToString();
                buton_6.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(6);
            }
        }

        private void buton_7_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_7.Text = oyuncu_harf.ToString();
                buton_7.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(7);
            }
        }

        private void buton_8_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_8.Text = oyuncu_harf.ToString();
                buton_8.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(8);
            }
        }

        private void buton_9_Click(object sender, EventArgs e)
        {
            if (baslama_komutu)
            {
                buton_9.Text = oyuncu_harf.ToString();
                buton_9.Enabled = false;
                hamle_sayisi++;
                sure_sayma();
                kim_kazandi();
                oyun_sira++;
                ileti_Gonder(9);
            }
        }

        private void buton_cekil_Click(object sender, EventArgs e)
        {
            ileti_Gonder(0);//Çekilirse 0 mesajı gönderiyor
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Oyuncu için zaman sayacı
            prgrsBar_oyuncu1.Value -= zaman_sayac * 10;

            if (prgrsBar_oyuncu1.Value == 0)
            {
                bitis(karsi_harf);
            }
        }
        void sure_sayma()
        {   //Süre sayma
            if (baslama_komutu)
            {//Başlama komutu doğru olmadıkça başlamıyor.
                if (oyun_sira % 2 == 0)
                {

                    timer1.Start();
                    //Zaman sayacını başlatıyor.
                }

                else
                {
                    timer1.Stop();
                    //Zaman sayacını durduruyor.
                }
            }

        }

        void bitis(string kazanan)
        {
            //Oyun biterse bütün her şeyi etkisiz hale getiriyor.
            timer1.Stop();
            tum_buton_etkisizlestirme();



            MessageBox.Show("Kazanan " + kazanan + ".Oyuncusu", "Kontrol Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();


        }

        void kim_kazandi()
        {   //Kimin kazandığını kontrol eden yer
            if ('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_2.Text && 'O'.ToString() == buton_3.Text)
            {
                buton_1.BackColor = Color.Red;
                buton_2.BackColor = Color.Red;
                buton_3.BackColor = Color.Red;
                bitis("O");
            }

            else if ('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_4.Text && 'O'.ToString() == buton_7.Text)
            {
                buton_1.BackColor = Color.Red;
                buton_4.BackColor = Color.Red;
                buton_7.BackColor = Color.Red;
                bitis("O");
            }

            else if ('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_1.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                bitis("O");
            }

            else if ('O'.ToString() == buton_2.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_8.Text)
            {
                buton_2.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_8.BackColor = Color.Red;
                bitis("O");
            }

            else if ('O'.ToString() == buton_3.Text && 'O'.ToString() == buton_6.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_3.BackColor = Color.Red;
                buton_6.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                bitis("O");
            }

            else if ('O'.ToString() == buton_4.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_6.Text)
            {
                buton_4.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_6.BackColor = Color.Red;
                bitis("O");
            }

            else if ('O'.ToString() == buton_7.Text && 'O'.ToString() == buton_8.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_7.BackColor = Color.Red;
                buton_8.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                bitis("O");
            }

            else if ('O'.ToString() == buton_7.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_3.Text)
            {
                buton_7.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_3.BackColor = Color.Red;
                bitis("O");
            }

            else if ('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_2.Text && 'X'.ToString() == buton_3.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_2.BackColor = Color.Blue;
                buton_3.BackColor = Color.Blue;
                bitis("X");
            }

            else if ('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_4.Text && 'X'.ToString() == buton_7.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_4.BackColor = Color.Blue;
                buton_7.BackColor = Color.Blue;
                bitis("X");
            }

            else if ('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                bitis("X");
            }

            else if ('X'.ToString() == buton_2.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_8.Text)
            {
                buton_2.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_8.BackColor = Color.Blue;
                bitis("X");
            }

            else if ('X'.ToString() == buton_3.Text && 'X'.ToString() == buton_6.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_3.BackColor = Color.Blue;
                buton_6.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                bitis("X");
            }

            else if ('X'.ToString() == buton_4.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_6.Text)
            {
                buton_4.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_6.BackColor = Color.Blue;
                bitis("X");
            }

            else if ('X'.ToString() == buton_7.Text && 'X'.ToString() == buton_8.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_7.BackColor = Color.Blue;
                buton_8.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                bitis("X");
            }

            else if ('X'.ToString() == buton_7.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_3.Text)
            {
                buton_7.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_3.BackColor = Color.Blue;
                bitis("X");
            }

            else
            {   //Hamle sayısı burada işe yarıyor.
                if (hamle_sayisi == 9)
                {
                    if (prgrsBar_oyuncu1.Value > prgrsBar_oyuncu2.Value) { bitis(oyuncu_harf); }
                    else { bitis(karsi_harf); }
                }

                else { }
            }

        }

        void tum_buton_etkisizlestirme()
        {   //Oyun bitmeden önce yapılması gereken.   
            buton_1.Enabled = false;
            buton_2.Enabled = false;
            buton_3.Enabled = false;
            buton_4.Enabled = false;
            buton_5.Enabled = false;
            buton_6.Enabled = false;
            buton_7.Enabled = false;
            buton_8.Enabled = false;
            buton_9.Enabled = false;

        }

        int zaman_sayac = 1, karsi_hamle = 0, karsi_oyuncu_sure = 10, hamle_sayisi = 0, oyun_sira;//oyunda gerekli değişkenler

        private void FormSunucuEklenti_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            prgrsBar_oyuncu1.Value = 100;
            prgrsBar_oyuncu2.Value = 100;
            //Zaman barı için gerekliler

            oyuncu_ip = frmXOX.gonderilecek_ip;
            oyuncu_port = frmXOX.gonderilecek_secim;
            //Bilgiler alındı

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            epLocal = new IPEndPoint(IPAddress.Parse(oyuncu_ip), Convert.ToInt32(oyuncu_port));
            sck.Bind(epLocal);
            // Sunucu kuruluyor.

            if (Convert.ToInt32(oyuncu_port) == 2) { oyuncu_harf = "X"; oyuncu_port = "1"; oyun_sira = 0; karsi_harf = "O"; }
            else { oyuncu_harf = "O"; oyuncu_port = "2"; karsi_harf = "O"; oyun_sira = 1; }

            //Harf ataması burada yapılıyor.
            epRemote = new IPEndPoint(IPAddress.Parse(oyuncu_ip), Convert.ToInt32(oyuncu_port));
            sck.Connect(epRemote);
            //Sunucuya bağlanılıyor
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            //Köprü dinleniliyor.


            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] oyunu_baslat = new byte[1500];
            oyunu_baslat = aEncoding.GetBytes("-2");
            // oyunu başlatma komutu
            sck.Send(oyunu_baslat);
        }
        private void MessageCallBack(IAsyncResult aResult)
        {   //Mesajı alma fonksiyonu
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //converting byte to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                //mesaj listbox a koyuluyor
                label1.Text = ("Client: " + receivedMessage);
                listBox1.Items.Add("Karsi" + receivedMessage);

                if (receivedMessage == "-2")
                {
                    baslama_komutu = true;

                }

                else if (Convert.ToInt32(receivedMessage) > 9)
                {
                    karsi_oyuncu_sure = Convert.ToInt32(receivedMessage) / 10;
                }

                else if (Convert.ToInt32(receivedMessage) == 0)
                {

                }

                else
                {
                    karsi_hamle = Convert.ToInt32(receivedMessage);
                }


                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //İleti gönderme fonksiyonu

        void ileti_Gonder(int message)
        {
            // convert string message to byte
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(message.ToString());
            // sending the encoded message
            sck.Send(sendingMessage);
            //adding to listbox
            label1.Text = ("Server: " + "1");
            listBox1.Items.Add("Senin" + sendingMessage.ToString());


        }

    }
}
