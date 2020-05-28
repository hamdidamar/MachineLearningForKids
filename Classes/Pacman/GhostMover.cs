using Entity_Layer;
using Entity_Layer.Interfaces;
using System;
using System.Drawing;

namespace Business_Layer
{
    public class GhostMover : IMove, IEating
    {
        Ghost ghost;
        MapObjectOperator mapObjectOperator;
        Random random = new Random();

        Directions oppositeDirection;
        bool isNewDirection = false;

        public GhostMover(Ghost ghost, MapObjectOperator mapObjectOperator)
        {
            this.ghost = ghost;
            this.mapObjectOperator = mapObjectOperator;
            ghost.currentDirection = Directions.Up;
            oppositeDirection = Directions.Down;
        }

        public void AutomaticMove()
        {
            switch (ghost.currentDirection)
            {
                case Directions.Up: MoveUp(); break;
                case Directions.Down: MoveDown(); break;
                case Directions.Left: MoveLeft(); break;
                case Directions.Right: MoveRight(); break;
                default: throw new Exception("Critical Error In Keys.Direction");
            }
        }

        private void FindDirection()
        {
            random.Next(); // For better random direction find.
            ghost.currentDirection = (Directions)random.Next((int)Directions.Left, (int)Directions.NoDirection);
            while (oppositeDirection == ghost.currentDirection)
                ghost.currentDirection = (Directions)random.Next((int)Directions.Left, (int)Directions.NoDirection);

            if (isNewDirection)
                AutomaticMove();
        }

        public void Eat(object eatenObject)
        {
            if (eatenObject != null)
            {
                mapObjectOperator.DestroyObject(eatenObject, ghost.objectType);
            }
        }

        private void MoveToOtherSpace()
        {
            int transportingXLocation = 0;


            if (ghost.image.Left <= 0)
                transportingXLocation = 360;

            Point point = new Point(transportingXLocation, ghost.image.Top);

            Eat(mapObjectOperator.GetObject(point));

            ghost.image.Left = transportingXLocation;
        }

        public void MoveDown()
        {

            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Down, ghost.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {

                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    ghost.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
                oppositeDirection = Directions.Up;
                isNewDirection = false;
            }
            else isNewDirection = true;

            FindDirection();
        }

        public void MoveLeft()
        {

            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Left, ghost.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {
                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    ghost.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
                oppositeDirection = Directions.Right;
                isNewDirection = false;
            }
            else isNewDirection = true;

            FindDirection();
        }

        public void MoveRight()
        {

            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Right, ghost.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {
                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    ghost.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
                oppositeDirection = Directions.Left;
                isNewDirection = false;
            }
            else isNewDirection = true;

            FindDirection();
        }

        public void MoveUp()
        {
            Point movingArea = mapObjectOperator.GetTargetMovingArea(Directions.Up, ghost.image.Location);
            if (!mapObjectOperator.IsWall(movingArea))
            {
                if (!mapObjectOperator.IsSpace(movingArea))
                {
                    Eat(mapObjectOperator.GetObject(movingArea));
                    ghost.image.Location = movingArea;
                }
                else
                    MoveToOtherSpace();
                oppositeDirection = Directions.Down;

                isNewDirection = false;
            }
            else isNewDirection = true;

            FindDirection();

        }
    }
}
