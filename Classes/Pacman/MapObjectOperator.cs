using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Layer
{
    public class MapObjectOperator
    {
        private GroupBox gameScreen;
        private List<OrdinaryFood> ordinaryFoods;
        public MapObjectOperator(GroupBox gameScreen, List<OrdinaryFood> ordinaryFoods)
        {
            this.gameScreen = gameScreen;
            this.ordinaryFoods = ordinaryFoods;
        }


        public bool IsWall(Point area)
        {
            Control child = gameScreen.GetChildAtPoint(area);
            if (child != null)
                return child.Name.Contains("wall");
            else
                return false;

        }
        public bool IsSpace(Point area)
        {
            return area.X <= 0 || area.X >= 380;
        }

        public object GetObject(Point area)
        {
            Control child = gameScreen.GetChildAtPoint(area);
            if (child != null)
                return child;
            else
                return null;
        }

        public Point GetTargetMovingArea(Directions direction, Point point)
        {
            Point movingArea = new Point(point.X, point.Y);
            switch (direction)
            {
                case Directions.Up: movingArea.Y -= 20; break;
                case Directions.Down: movingArea.Y += 20; break;
                case Directions.Left: movingArea.X -= 20; break;
                case Directions.Right: movingArea.X += 20; break;
                default: break;

            }
            return movingArea;
        }

        public void DestroyObject(object destroyingObject, ImageObjectType destroyerObjectType)
        {
            switch (destroyerObjectType)
            {
                case ImageObjectType.PACMAN: PacmanDestroyObject(destroyingObject); break;
                case ImageObjectType.GHOST: GhostDestroyObject(destroyingObject); break;
                default: break;

            }
        }

        private void PacmanDestroyObject(object destroyingObject)
        {
            foreach (var currentFood in ordinaryFoods)
            {
                if (currentFood.image == destroyingObject)
                {
                    ordinaryFoods.Remove(currentFood);
                    currentFood.Dispose();
                    break;
                }
            }
        }

        private void GhostDestroyObject(object destroyingObject)
        {
            Control convertedObject = (Control) destroyingObject;
            if (IsPacman(convertedObject.Location))
                convertedObject.Dispose();
        }

        private bool IsPacman(Point area)
        {
            Control child = gameScreen.GetChildAtPoint(area);
            if (child != null)
                return child.Name.Contains("Pacman");
            else
                return false;
        }
    }
}
