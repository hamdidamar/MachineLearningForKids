using GameBoard;
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
    public partial class UIHumanVsAI : Form
    {
        public UIHumanVsAI()
        {
            InitializeComponent();
        }
        int timeRecorder = 1;
        int roundNum;
        BoardSquares boardSquares;

        string[] imagePaths = new string[2];
        private void UIHumanVsAI_Load(object sender, EventArgs e)
        {
            boardSquares = new BoardSquares();
            roundNum = 0;
            TakeResources();
            StartGame();
        }
        private void StartGame()
        {
            Player1Timer.Interval = 1000;
            Player2Timer.Interval = 1000;

            prgrss_Player1.Value = 100;
            prgrss_Player2.Value = 100;

            Player1Timer.Start();
        }

        private void TakeResources()
        {
            lbl_Player1Name.Text = frmXOX.gonderilecek_ad1;
            lbl_Player2Name.Text = frmXOX.gonderilecek_ad2;
            imagePaths[0] = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/Resources/SquareXImg.png";
            imagePaths[1] = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/Resources/SquareOImg.png";
        }

        private void MoveOperationSend(int squareNum)
        {
            roundNum++;

            int winnerNum = boardSquares.PlayToSquare(squareNum);

            GameFinishController(winnerNum);

            TimeRecorder();
        }

        private void GameFinishController(int winnerNum)
        {
            if (winnerNum != 0)
            {
                FinishGame(winnerNum);
            }

            DrawController();

        }

        private void DrawController()
        {
            if (roundNum == 9)
            {
                if (prgrss_Player1.Value > prgrss_Player2.Value)
                {
                    FinishGame(1);
                }

                else
                {
                    FinishGame(2);
                }
            }
        }

        private void TimeRecorder()
        {
            if (Player1Timer.Enabled)
            {
                Player1Timer.Stop();
                Player2Timer.Start();
            }

            else
            {
                Player1Timer.Start();
                Player2Timer.Stop();
            }

        }

        void FinishGame(int winnerPlayerNum)
        {

            Player2Timer.Stop();
            Player1Timer.Stop();

            MessageBox.Show("Winner: " + winnerPlayerNum.ToString() + ".Player", "End Game Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();


        }

        private void pctr_Square1_Click(object sender, EventArgs e)
        {
            pctr_Square1.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square1.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(1);
            pctr_Square1.Enabled = false;
        }

        private void pctr_Square2_Click(object sender, EventArgs e)
        {
            pctr_Square2.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square2.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(2);
            pctr_Square2.Enabled = false;
        }

        private void pctr_Square3_Click(object sender, EventArgs e)
        {
            pctr_Square3.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square3.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(3);
            pctr_Square3.Enabled = false;
        }

        private void pctr_Square4_Click(object sender, EventArgs e)
        {
            pctr_Square4.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square4.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(4);
            pctr_Square4.Enabled = false;
        }

        private void pctr_Square5_Click(object sender, EventArgs e)
        {
            pctr_Square5.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square5.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(5);
            pctr_Square5.Enabled = false;
        }

        private void pctr_Square6_Click(object sender, EventArgs e)
        {
            pctr_Square6.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square6.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(6);
            pctr_Square6.Enabled = false;
        }

        private void pctr_Square7_Click(object sender, EventArgs e)
        {
            pctr_Square7.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square7.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(7);
            pctr_Square7.Enabled = false;
        }

        private void pctr_Square8_Click(object sender, EventArgs e)
        {
            pctr_Square8.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square8.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(8);
            pctr_Square8.Enabled = false;
        }

        private void pctr_Square9_Click(object sender, EventArgs e)
        {
            pctr_Square9.Image = Image.FromFile(imagePaths[roundNum % 2]);
            pctr_Square9.SizeMode = PictureBoxSizeMode.StretchImage;
            MoveOperationSend(9);
            pctr_Square9.Enabled = false;
        }

        private void Player1Timer_Tick(object sender, EventArgs e)
        {
            prgrss_Player1.Value -= timeRecorder * 10;

            if (prgrss_Player1.Value == 0)
            {
                FinishGame(2);
            }
        }

        private void Player2Timer_Tick(object sender, EventArgs e)
        {
            prgrss_Player2.Value -= timeRecorder * 10;

            if (prgrss_Player2.Value == 0)
            {
                FinishGame(1);

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
