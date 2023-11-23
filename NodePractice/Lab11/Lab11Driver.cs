using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Lab11Driver
    {
        static void Main(string[] args)
        {
            // Contemplating adding methods to naviagate the nodes

            BlueRayCollections myCollection = new BlueRayCollections();
            int choice = -1;
            string title = null;
            string director = null;
            int releaseYear = 0;
            double cost = 0;

            do
            {
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Add BlueRay to collection");
                Console.WriteLine("2. See collection");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("What is the title?");
                    title = Console.ReadLine();
                    Console.WriteLine("What is the director?");
                    director = Console.ReadLine();
                    Console.WriteLine("What is the year of release?");
                    releaseYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the cost?");
                    cost = Convert.ToDouble(Console.ReadLine());

                    myCollection.add(title, director, releaseYear, cost);
                }
                else if (choice == 2)
                {
                    myCollection.showAll();
                }
                Console.WriteLine("\n");
            } while (choice != 0);
            Console.WriteLine("Shutting down...");
        }
    }
}
