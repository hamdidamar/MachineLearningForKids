using MachineLearningForKids.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFaceRecognition_Click(object sender, EventArgs e)
        {
            frmFaceRecognition faceRecognition = new frmFaceRecognition();
            faceRecognition.Show();
                
        }

        private void btnRockPaperScissors_Click(object sender, EventArgs e)
        {
            frmRockPaperScissors rockPaperScissors = new frmRockPaperScissors();
            rockPaperScissors.ShowDialog();
        }

        private void btnCarOrCup_Click(object sender, EventArgs e)
        {
            frmCarOrCup carOrCup = new frmCarOrCup();
            carOrCup.Show();
        }

        private void btnPlayingCards_Click(object sender, EventArgs e)
        {
            frmPlayingCards playingCards = new frmPlayingCards();
            playingCards.Show();
        }

        private void btnTitaticSurvivor_Click(object sender, EventArgs e)
        {
            frmTitanic titanic = new frmTitanic();
            titanic.Show();
        }
    }
}
