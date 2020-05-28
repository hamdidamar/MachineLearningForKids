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
    public partial class MachineLearningForKids : Form
    {
        public MachineLearningForKids()
        {
            InitializeComponent();
        }

        private void btnFaceRecognition_Click(object sender, EventArgs e)
        {
            frmFaceRecognition faceRecognition = new frmFaceRecognition();
            faceRecognition.ShowDialog();
                
        }

        private void btnRockPaperScissors_Click(object sender, EventArgs e)
        {
            frmRockPaperScissors rockPaperScissors = new frmRockPaperScissors();
            rockPaperScissors.ShowDialog();
        }

        private void btnCarOrCup_Click(object sender, EventArgs e)
        {
            frmCarOrCup carOrCup = new frmCarOrCup();
            carOrCup.ShowDialog();
        }

        private void btnPlayingCards_Click(object sender, EventArgs e)
        {
            frmPlayingCards playingCards = new frmPlayingCards();
            playingCards.ShowDialog();
        }

        private void btnTitaticSurvivor_Click(object sender, EventArgs e)
        {
            frmTitanic titanic = new frmTitanic();
            titanic.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLessonSentiment_Click(object sender, EventArgs e)
        {
            frmLessons lessons = new frmLessons();
            lessons.ShowDialog();
        }

        private void btnTouristInformation_Click(object sender, EventArgs e)
        {
            frmTouristInformation touristInformation = new frmTouristInformation();
            touristInformation.ShowDialog();
        }

        private void btnPacman_Click(object sender, EventArgs e)
        {
            frmPacman pacman = new frmPacman();
            pacman.ShowDialog();
        }
    }
}
