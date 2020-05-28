using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.AIUtility
{
    public class BestDirectionHeap
    {
        private List<BestDirectionHeapNode> heapNodes = new List<BestDirectionHeapNode>();
        private int currentSize = 0;

        public void ResetHeap()
        {
            heapNodes.Clear();
            currentSize = 0;
        }

        public void AddNode(BestDirectionHeapNode newNode)
        {
            heapNodes.Add(newNode);
            MoveToUp(currentSize++);
        }

        private void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            BestDirectionHeapNode bottom = heapNodes[index];
            while (index > 0 && heapNodes[parent].statementValue <= bottom.statementValue)
            {
                if (heapNodes[parent].statementValue == bottom.statementValue && heapNodes[parent].direction > bottom.direction)
                    break;


                heapNodes[index] = heapNodes[parent];
                index = parent;
                parent = (parent - 1) / 2;

            }
            heapNodes[index] = bottom;
        }

        public BestDirectionHeapNode GetBestNode()
        {
            BestDirectionHeapNode cd = heapNodes[0];
            string message = "";
            while (cd.parentNode != null)
            {
                message += "|" + cd.direction.ToString() + cd.statementValue.ToString();
                cd = cd.parentNode;
            }

            Console.WriteLine(message +"||" + cd.statementValue);

            return heapNodes[0];
        }

    }
}
