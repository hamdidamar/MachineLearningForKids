using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.AIUtility
{
    public class PacmanAIOperator
    {

        private readonly ThePacman thePacman;
        private readonly Ghost[] ghosts;
        private readonly BestDirectionHeap directionHeap;
        private readonly int maxDepthLevel;
        private readonly MapObjectOperator mapObjectOperator;
        private readonly List<OrdinaryFood> ordinaryFoods;
        public PacmanAIOperator(ThePacman thePacman, Ghost[] ghosts, MapObjectOperator mapObjectOperator, int maxDepthLevel, List<OrdinaryFood> ordinaryFoods)
        {
            this.thePacman = thePacman;
            this.ghosts = ghosts;
            this.mapObjectOperator = mapObjectOperator;
            this.directionHeap = new BestDirectionHeap();
            this.maxDepthLevel = maxDepthLevel;
            this.ordinaryFoods = ordinaryFoods;
        }

        public Directions FindBestDirection()
        {
            CreateHeap();
            BestDirectionHeapNode bestNode = directionHeap.GetBestNode();

            while (bestNode.parentNode.parentNode != null)
            {
                bestNode = bestNode.parentNode;

            }

            if (bestNode.statementValue > 100)
            {
                Console.WriteLine(GetDirectionForFood(FindNearestFoodLocation(thePacman.image.Location)));
                return GetDirectionForFood(FindNearestFoodLocation(thePacman.image.Location));
            }

            return bestNode.direction;

        }

        private void CreateHeap()
        {
            directionHeap.ResetHeap();

            BestDirectionHeapNode rootNode = new BestDirectionHeapNode(Directions.NoDirection, GetManhattanDistanceFromGhosts(thePacman.image.Location), thePacman.image.Location, null);

            AddDirectionsToHeap(rootNode, 0);

        }

        private void AddDirectionsToHeap(BestDirectionHeapNode parentNode, int depthLevel)
        {


            if (depthLevel < maxDepthLevel)
            {
                for (int directionRecorder = 0; directionRecorder < (int)Directions.NoDirection; directionRecorder++)
                {

                    Point childLocation = mapObjectOperator.GetTargetMovingArea((Directions)directionRecorder, parentNode.location);
                    if (!mapObjectOperator.IsWall(childLocation))
                    {
                        BestDirectionHeapNode newNode = new BestDirectionHeapNode((Directions)directionRecorder, GetManhattanDistanceFromGhosts(childLocation), childLocation, parentNode);

                        AddDirectionsToHeap(newNode, depthLevel + 1);
                    }

                }
            }

            else
            {
                directionHeap.AddNode(parentNode);
            }
        }

        private int GetManhattanDistanceFromGhosts(Point currentLocation)
        {
            int totalManhattanDistance = 0;

            foreach (var ghost in ghosts)
            {
                int manhattanDistance = FindManhattanDistance(currentLocation, ghost.image.Location);

                totalManhattanDistance += manhattanDistance;
            }

            return totalManhattanDistance;
        }

        private Point FindNearestFoodLocation(Point currentLocation)
        {
            int nearestManhattanDistance = 9999;
            OrdinaryFood nearestFood = null;

            foreach (var food in ordinaryFoods)
            {
                int manhattanDistance = FindManhattanDistance(currentLocation, food.image.Location);
                if (manhattanDistance < nearestManhattanDistance)
                {
                    nearestManhattanDistance = manhattanDistance;
                    nearestFood = food;
                }

            }
            nearestFood.image.BackColor = Color.Red;
            return nearestFood.image.Location;
        }

        private Directions GetDirectionForFood(Point location)
        {
            int xDifference = thePacman.image.Location.X - location.X;
            int yDifference = thePacman.image.Location.Y - location.Y;
            Console.WriteLine(xDifference);
            Console.WriteLine(yDifference);
            Directions direction = Directions.NoDirection;

            direction = GetDirectionHorizontal(thePacman.image.Location, xDifference);

            if (direction == Directions.NoDirection)
                direction = GetDirectionVertical(thePacman.image.Location, yDifference);

            return direction;

        }

        private Directions GetDirectionHorizontal(Point location, int xDifference)
        {
            Directions defaultDirection = Directions.NoDirection;

            if (xDifference > 0 && !mapObjectOperator.IsWall(mapObjectOperator.GetTargetMovingArea(Directions.Left,location)))
                defaultDirection = Directions.Left;

            if (xDifference < 0 && !mapObjectOperator.IsWall(mapObjectOperator.GetTargetMovingArea(Directions.Right,location)))
                defaultDirection = Directions.Right;

            return defaultDirection;

        }

        private Directions GetDirectionVertical(Point location, int yDifference)
        {
            Directions defaultDirection = Directions.NoDirection;

            if (yDifference > 0 && !mapObjectOperator.IsWall(mapObjectOperator.GetTargetMovingArea(Directions.Up, location)))
                defaultDirection = Directions.Up;

            if (yDifference < 0 && !mapObjectOperator.IsWall(mapObjectOperator.GetTargetMovingArea(Directions.Down, location)))
                defaultDirection = Directions.Down;

            return defaultDirection;
        }

        private int FindManhattanDistance(Point location1, Point location2)
        {
            return Math.Abs(location1.X - location2.X) + Math.Abs(location1.Y - location2.Y);
        }
    }
}
