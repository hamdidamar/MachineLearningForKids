using Business_Layer;
using Business_Layer.AIUtility;
using Entity_Layer;
using Presentation_Layer;
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
    public partial class frmPacman : Form
    {
        public frmPacman()
        {
            InitializeComponent();
        }

        private void timer_PacmanMover_Tick(object sender, EventArgs e)
        {
            IsFinish();
            MovePacman(pacmanAI.FindBestDirection());
        }

        private void timer_GhostMover_Tick(object sender, EventArgs e)
        {
            IsFinish();
            for (int ghostRecorder = 0; ghostRecorder < ghosts.Length; ghostRecorder++)
            {
                ghostMovers[ghostRecorder].AutomaticMove();
            }
        }
        private void FinishGame()
        {

            timer_GhostMover.Stop();
            timer_PacmanMover.Stop();

        }
        private bool IsFinish()
        {
            for (int ghostRecorder = 0; ghostRecorder < ghosts.Length; ghostRecorder++)
            {
                if (ghosts[ghostRecorder].image.Bounds.Contains(thePacman.image.Location))
                {
                    thePacman.Dispose();

                    FinishGame();

                    ShowFinishMessage(ImageObjectType.GHOST);

                    return true;
                }
            }

            if (ordinaryFoods.Count == 0)
            {
                FinishGame();

                ShowFinishMessage(ImageObjectType.PACMAN);

                return true;
            }
            else
                return false;
        }

        private void ShowFinishMessage(ImageObjectType winnerObjectType)
        {
            MessageBox.Show("Oyun Bitti!");
            lblSonuc.Text = winnerObjectType.ToString();
            lblKazanan.Visible = true;
            lblSonuc.Visible = true;
            btnTekrar.Visible = true;
            //Application.Exit();

        }
        private void MovePacman(Directions direction)
        {
            switch (direction)
            {
                case Directions.Up: pacmanMover.MoveUp(); break;
                case Directions.Down: pacmanMover.MoveDown(); break;
                case Directions.Left: pacmanMover.MoveLeft(); break;
                case Directions.Right: pacmanMover.MoveRight(); break;
                default: break;

            }
        }
        private void LoadGhostMovementUtility()
        {

            timer_GhostMover.Interval = TIMERDEFAULTINTERVAL / (int)ghosts[0].movementSpeed;
            timer_GhostMover.Start();

        }
        private void LoadPacmanMovementUtility()
        {
            timer_PacmanMover.Interval = TIMERDEFAULTINTERVAL / (int)thePacman.movementSpeed;
            timer_PacmanMover.Start();
        }
        private PacmanMover pacmanMover;
        private GhostMover[] ghostMovers;
        private List<OrdinaryFood> ordinaryFoods;
        private ThePacman thePacman;
        private Ghost[] ghosts;
        MapObjectOperator mapObjectOperator;
        private const int TIMERDEFAULTINTERVAL = 3000;
        private PacmanAIOperator pacmanAI;
        private void frmPacman_Load(object sender, EventArgs e)
        {
            ImageCreater imageCreater = new ImageCreater(grpBox_GameScreen);
            thePacman = imageCreater.CreatePacman();
            ghosts = imageCreater.CreateGhosts();
            ordinaryFoods = imageCreater.CreateFoods();
            mapObjectOperator = new MapObjectOperator(grpBox_GameScreen, ordinaryFoods);
            pacmanMover = new PacmanMover(thePacman, mapObjectOperator);
            ghostMovers = new GhostMover[ghosts.Length];
            pacmanAI = new PacmanAIOperator(thePacman, ghosts, mapObjectOperator, 5, ordinaryFoods);

            for (int ghostRecorder = 0; ghostRecorder < ghosts.Length; ghostRecorder++)
            {
                ghostMovers[ghostRecorder] = new GhostMover(ghosts[ghostRecorder], mapObjectOperator);
            }

            LoadGhostMovementUtility();
            LoadPacmanMovementUtility();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            frmPacman pacman = new frmPacman();
            pacman.ShowDialog();
            this.Close();
        }
    }
}
