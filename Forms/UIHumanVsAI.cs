using GameAI;
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
        PictureBox[] pictureSquares;
        AIOperations aIOperations;
        BoardSquares boardSquares;
        int roundNum;
        int aIDifficulty = frmXOX.gonderilecek_zorluk;
        string[] imagePaths = new string[2];
        char humanSymbol;
        char aISymbol;
        int aIMoveTurnNum;
        int humanMoveTurnNum;

        bool gameFinished;
        int aIFabilityRate;
        private void UIHumanVsAI_Load(object sender, EventArgs e)
        {
            boardSquares = new BoardSquares();
            pictureSquares = new PictureBox[9];
            StartGame();
        }
        private void StartGame()
        {
            TakePlayerSymbol();
            TakeResources();
            ImportResources();
            aIOperations = new AIOperations(aISymbol, humanSymbol);
            ActivateAI();

        }


        private void TakePlayerSymbol()
        {
            DialogResult choiceSymbolDialog = MessageBox.Show("Do you want to play with the X Symbol?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (DialogResult.Yes == choiceSymbolDialog) { humanSymbol = 'X'; aISymbol = 'O'; humanMoveTurnNum = 0; aIMoveTurnNum = 1; }
            else if (DialogResult.No == choiceSymbolDialog) { humanSymbol = 'O'; aISymbol = 'X'; humanMoveTurnNum = 1; aIMoveTurnNum = 0; }
            else { Close(); }
        }

        private void ActivateAI()
        {
            if (roundNum % 2 == aIMoveTurnNum && !gameFinished)
            {
                roundNum++;
                int moveOfAI = aIOperations.MakeMove(0);
                int winnerNum = boardSquares.PlayToSquare(moveOfAI);
                UpdateSquareInformation(aIMoveTurnNum, moveOfAI);
                GameFinishController(winnerNum);

            }
        }

        private void TakeResources()
        {

            lbl_Player1Name.Text = frmXOX.gonderilecek_ad1;
            imagePaths[0] = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/Resources/SquareXImg.png";
            imagePaths[1] = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/Resources/SquareOImg.png";

            aIFabilityRate = 100 - frmXOX.gonderilecek_zorluk;
        }

        private void ImportResources()
        {
            gameFinished = false;
            roundNum = 0;

            pictureSquares[0] = pctr_Square1;
            pictureSquares[1] = pctr_Square2;
            pictureSquares[2] = pctr_Square3;
            pictureSquares[3] = pctr_Square4;
            pictureSquares[4] = pctr_Square5;
            pictureSquares[5] = pctr_Square6;
            pictureSquares[6] = pctr_Square7;
            pictureSquares[7] = pctr_Square8;
            pictureSquares[8] = pctr_Square9;
        }


        private void MoveOperationSend(int squareNum)
        {
            roundNum++;
            int winnerNum = boardSquares.PlayToSquare(squareNum);
            GameFinishController(winnerNum);
        }

        private void GameFinishController(int winnerNum)
        {
            if (winnerNum != 0)
            {
                FinishGame(winnerNum);
            }

            DrawController();

        }
        private void UpdateSquareInformation(int moverTurnNum, int squareNum)
        {
            pictureSquares[squareNum - 1].Image = Image.FromFile(imagePaths[moverTurnNum]);
            pictureSquares[squareNum - 1].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSquares[squareNum - 1].Enabled = false;
        }
        private void DrawController()
        {
            if (roundNum == 9)
            {
                gameFinished = true;
                MessageBox.Show("Game Draw!", "End Game Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        void FinishGame(int winnerPlayerNum)
        {
            gameFinished = true;

            MessageBox.Show("Winner: " + winnerPlayerNum.ToString() + ".Player", "End Game Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void MakeMove(int squareNum)
        {
            UpdateSquareInformation(humanMoveTurnNum, squareNum);
            MoveOperationSend(squareNum);
            ActivateAI();

        }
        private void pctr_Square1_Click(object sender, EventArgs e)
        {
            MakeMove(1);
        }

        private void pctr_Square2_Click(object sender, EventArgs e)
        {
            MakeMove(2);
        }

        private void pctr_Square3_Click(object sender, EventArgs e)
        {
            MakeMove(3);
        }

        private void pctr_Square4_Click(object sender, EventArgs e)
        {
            MakeMove(4);
        }

        private void pctr_Square5_Click(object sender, EventArgs e)
        {
            MakeMove(5);
        }

        private void pctr_Square6_Click(object sender, EventArgs e)
        {
            MakeMove(6);
        }

        private void pctr_Square7_Click(object sender, EventArgs e)
        {
            MakeMove(7);
        }

        private void pctr_Square8_Click(object sender, EventArgs e)
        {
            MakeMove(8);
        }

        private void pctr_Square9_Click(object sender, EventArgs e)
        {
            MakeMove(9);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
