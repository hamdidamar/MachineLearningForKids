using Entity_Layer;
using MachineLearningForKids.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public class ImageCreater
    {

        const int IMAGELENGHT = 20;
        const int IMAGEHEIGHT = 20;

        private readonly GroupBox gameScreen;
        public ImageCreater(GroupBox gameScreen)
        {
            this.gameScreen = gameScreen;
        }

        public ThePacman CreatePacman()
        {
            PictureBox pacmanPicture = new PictureBox
            {
                Image =  Image.FromFile(Application.StartupPath + "\\images\\Pacman.png"),
                Location = new Point(340, 420),
                Name = "image_Pacman",
                Size = new Size(IMAGELENGHT, IMAGEHEIGHT),
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabIndex = 56,
                TabStop = false
            };
            gameScreen.Controls.Add(pacmanPicture);

            ThePacman thePacman = new ThePacman
            {
                image = pacmanPicture
            };

            return thePacman;

        }


        public Ghost[] CreateGhosts()
        {
            Ghost[] ghosts = new Ghost[2];

            PictureBox outCellGhostPicture = new PictureBox
            {
                Image = Image.FromFile(Application.StartupPath + "\\images\\BlueGhostIcon.png"),
                Location = new Point(180, 160),
                Name = "image_Ghost" + "1",
                Size = new Size(IMAGELENGHT, IMAGEHEIGHT),
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabIndex = 56,
                TabStop = false
            };

            gameScreen.Controls.Add(outCellGhostPicture);

            Ghost outCellGhost = new Ghost
            {
                image = outCellGhostPicture
            };

            ghosts[0] = outCellGhost;

            for (int ghostNumber = 1; ghostNumber < ghosts.Length; ghostNumber++)
            {
                PictureBox inCellGhostPicture = new PictureBox
                {
                    Image = Image.FromFile(Application.StartupPath + "\\images\\BlueGhostIcon.png"),
                    Location = new Point(outCellGhostPicture.Left+IMAGELENGHT - (IMAGELENGHT * (ghostNumber-1)), outCellGhostPicture.Top + IMAGEHEIGHT*2),
                    Name = "image_Ghost" + ghostNumber+1.ToString(),
                    Size = new Size(IMAGELENGHT, IMAGEHEIGHT),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    TabIndex = 56,
                    TabStop = false
                };

                gameScreen.Controls.Add(inCellGhostPicture);

                Ghost currentGhost = new Ghost
                {
                    image = inCellGhostPicture
                };

                ghosts[ghostNumber] = currentGhost;
            }

    
            return ghosts;
        }

        public List<OrdinaryFood> CreateFoods()
        {
            List<OrdinaryFood> ordinaryFoods = new List<OrdinaryFood>();

            int foodCount = 0;
            for (int currentYPosition = 0; currentYPosition < gameScreen.Height; currentYPosition += IMAGEHEIGHT)
            {
                for (int currentXPosition = 0; currentXPosition < gameScreen.Width; currentXPosition += IMAGELENGHT)
                {

                    Point currentPoint = new Point(currentXPosition, currentYPosition);

                    if (gameScreen.GetChildAtPoint(currentPoint) == null)
                    {
                        Label newFoodImage = new Label();
                        foodCount++;
                        newFoodImage.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                        newFoodImage.ForeColor = Color.Yellow;
                        newFoodImage.Location = new Point(currentXPosition, currentYPosition);
                        newFoodImage.Name = "food" + (foodCount).ToString();
                        newFoodImage.Size = new Size(IMAGELENGHT, IMAGEHEIGHT);
                        newFoodImage.TabIndex = 56;
                        newFoodImage.Text = "•";
                        gameScreen.Controls.Add(newFoodImage);
                        OrdinaryFood newOrdinaryFood = new OrdinaryFood
                        {
                            image = newFoodImage
                        };

                        ordinaryFoods.Add(newOrdinaryFood);
                    }
                }

            }

            return ordinaryFoods;
        }

    }

}

