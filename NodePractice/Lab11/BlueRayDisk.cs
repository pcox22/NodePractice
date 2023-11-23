using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class BlueRayDisk
    {
        public string title;
        public string director;
        public int releaseYear;
        public double cost;

        public BlueRayDisk(string title, string director, int releaseYear, double cost)
        {
            this.title = title;
            this.director = director;
            this.releaseYear = releaseYear;
            this.cost = cost;
        }

        public string toString()
        {
            return "$" + cost + " " + releaseYear + " " + title + ", " + director;
        }
    }
}
