using Business_Layer.AIUtility;
using Entity_Layer;
using Entity_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class PacmanMover : IMove, IEating
    {
        private ThePacman thePacman;
        private MapObjectOperator mapObjectOperator;

        public PacmanMover(ThePacman thePacman, MapObjectOperator mapObjectOperator)
        {
            this.thePacman = thePacman;
            this.mapObjectOperator = mapObjectOperator;
        }

        public void Eat(object eatenObject)
        {
            if (eatenObject != null)
            {
                mapObjectOperator.DestroyObject(eatenObject, thePacman.objectType);
            }
        }


        private void MoveToOtherSpace()
        {
            int transportingXLocation = 0;


            if (thePacman.image.Left <= 0)
                transportingXLocation = 360;

            Point point = new Point(transportingXLocation, thePacman.image.Top);

            Eat(mapObjectOperator.GetObject(point));

            thePacman.image.Left = transportingXLocation;
        }

        public void MoveDown()
        {
            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Down, thePacman.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {

                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    thePacman.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
            }


        }

        public void MoveLeft()
        {
            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Left, thePacman.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {
                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    thePacman.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
            }

        }

        public void MoveRight()
        {
            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Right, thePacman.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {
                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    thePacman.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
            }


        }

        public void MoveUp()
        {
            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Up, thePacman.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {
                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    thePacman.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
            }

        }

    }
}
