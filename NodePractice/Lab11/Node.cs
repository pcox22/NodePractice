using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Node
    {
        public BlueRayDisk topDisk;
        public Node nextNode;
        public Node(BlueRayDisk topDisk, Node nextNode)
        {
            this.topDisk = topDisk;
            this.nextNode = nextNode;
        }


        public void addNode(Node move)
        {
            nextNode = move;
        }
        public void switchNode(Node callNode, Node newNode)
        {
            Node tempNode = nextNode;
            while (nextNode != null)
            {
                
            }
        }


    }
}
