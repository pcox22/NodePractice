using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class BlueRayCollections
    {
        private Node head = null;

        public void add(string title, string director, int releaseYear, double cost)
        {
            BlueRayDisk newDisk = new BlueRayDisk(title, director, releaseYear, cost);
            Node newEnd = new Node(newDisk, null);

            try
            {
                if (head == null)
                {
                    head = newEnd;
                }
                else
                {
                    Node last = head;
                    while (last.nextNode != null)
                    {
                        last = last.nextNode;
                    }
                    last.nextNode = newEnd;
                }
                
                
            }
            catch (NullReferenceException)
            {

            }

            

        }

        public void showAll()
        {
            
            try
            {
                Node headRef = head;
                while (head != null)
                {
                    Console.WriteLine(headRef.topDisk.toString());
                    headRef = headRef.nextNode;
                    if (headRef == null)
                    {
                        Console.WriteLine(headRef.topDisk.toString());
                    }

                }
            }
            catch (NullReferenceException)
            {

            }
        }
    }
}
