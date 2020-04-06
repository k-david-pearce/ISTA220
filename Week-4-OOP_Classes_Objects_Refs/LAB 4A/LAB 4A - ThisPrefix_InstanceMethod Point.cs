#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
             
        private int x, y;
        
        public Point() //public default constructor
        {
            this.x = -1; //prefixing with 'this' means 'the field in this object'
            this.y = -1;
        }
        
        public Point(int x, int y) //public constructor that accepts two args
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(Point other) // instance method
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
    }
}
