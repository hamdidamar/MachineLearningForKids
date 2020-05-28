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
    public partial class frmTouristInformation : Form
    {
        public frmTouristInformation()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (cmbSehir.Text == "İstanbul")
            {
                IzmirGizle();
                IstanbulGoster();
            }
            if (cmbSehir.Text =="İzmir")
            {
                IstanbulGizle();
                IzmirGoster();
            }
        }

        void IstanbulGoster()
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            lblBaslik1.Visible = true;
            lblBaslik2.Visible = true;
            lblBaslik3.Visible = true;
            imgIstanbul1.Visible = true;
            imgIstanbul2.Visible = true;
            imgIstanbul3.Visible = true;
            imgIstanbul4.Visible = true;
            imgIstanbul5.Visible = true;
            imgIstanbul6.Visible = true;
            lbİstanbul1.Visible = true;
            lbİstanbul2.Visible = true;
            lbİstanbul3.Visible = true;
            lbİstanbul4.Visible = true;
            lbİstanbul5.Visible = true;
            lbİstanbul6.Visible = true;
            lbİstanbul7.Visible = true;
            lbİstanbul8.Visible = true;
            lbİstanbul9.Visible = true;
            lbİstanbul10.Visible = true;
            lbİstanbul11.Visible = true;
            lbİstanbul12.Visible = true;
        }
        void IzmirGoster()
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            lblBaslik1.Visible = true;
            lblBaslik2.Visible = true;
            lblBaslik3.Visible = true;
            imgIzmir1.Visible = true;
            imgIzmir2.Visible = true;
            imgIzmir3.Visible = true;
            imgIzmir4.Visible = true;
            imgIzmir5.Visible = true;
            imgIzmir6.Visible = true;
            lblIzmir1.Visible = true;
            lblIzmir2.Visible = true;
            lblIzmir3.Visible = true;
            lblIzmir4.Visible = true;
            lblIzmir5.Visible = true;
            lblIzmir6.Visible = true;
            lblIzmir7.Visible = true;
            lblIzmir8.Visible = true;
            lblIzmir9.Visible = true;
            lblIzmir10.Visible = true;
            lblIzmir11.Visible = true;
            lblIzmir12.Visible = true;
        }
        void IstanbulGizle()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            lblBaslik1.Visible = false;
            lblBaslik2.Visible = false;
            lblBaslik3.Visible = false;
            imgIstanbul1.Visible = false;
            imgIstanbul2.Visible = false;
            imgIstanbul3.Visible = false;
            imgIstanbul4.Visible = false;
            imgIstanbul5.Visible = false;
            imgIstanbul6.Visible = false;
            lbİstanbul1.Visible = false;
            lbİstanbul2.Visible = false;
            lbİstanbul3.Visible = false;
            lbİstanbul4.Visible = false;
            lbİstanbul5.Visible = false;
            lbİstanbul6.Visible = false;
            lbİstanbul7.Visible = false;
            lbİstanbul8.Visible = false;
            lbİstanbul9.Visible = false;
            lbİstanbul10.Visible = false;
            lbİstanbul11.Visible = false;
            lbİstanbul12.Visible = false;
        }
        void IzmirGizle()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            lblBaslik1.Visible = false;
            lblBaslik2.Visible = false;
            lblBaslik3.Visible = false;
            imgIzmir1.Visible = false;
            imgIzmir2.Visible = false;
            imgIzmir3.Visible = false;
            imgIzmir4.Visible = false;
            imgIzmir5.Visible = false;
            imgIzmir6.Visible = false;
            lblIzmir1.Visible = false;
            lblIzmir2.Visible = false;
            lblIzmir3.Visible = false;
            lblIzmir4.Visible = false;
            lblIzmir5.Visible = false;
            lblIzmir6.Visible = false;
            lblIzmir7.Visible = false;
            lblIzmir8.Visible = false;
            lblIzmir9.Visible = false;
            lblIzmir10.Visible = false;
            lblIzmir11.Visible = false;
            lblIzmir12.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
