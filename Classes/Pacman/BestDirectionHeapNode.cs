using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.AIUtility
{
    public class BestDirectionHeapNode
    {
        public Directions direction;
        public int manhattanDistance;
        public BestDirectionHeapNode parentNode;
        public Point location;

        public int statementValue { get; set; }
        public int totalPathCost { get; set; }

        public BestDirectionHeapNode(Directions direction, int manhattanDistance, Point location, BestDirectionHeapNode parentNode)
        {
            this.direction = direction;
            this.manhattanDistance = manhattanDistance;
            this.parentNode = parentNode;
            this.location = location;

            if (parentNode != null)
                statementValue = manhattanDistance + parentNode.manhattanDistance;
            else
                statementValue = manhattanDistance;
        }
    }
}
