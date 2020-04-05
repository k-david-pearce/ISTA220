using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point(); //creates new instance of point; invokes its default constructor
            Point bottomRight = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            (int xVal, int yVal) = origin; // deconstruct to retrieve private fields
            Console.WriteLine($"Deconstructor values. x = {xVal}, y = {yVal}");
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
            //try
            //{
            //    doWork();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            int num = 4;
            Console.WriteLine($"number is {multiply(num)}"); 

        }

        public static int multiply(int param) => param * param;

        //Point origin = new Point();
        //(int xVal, int yVal) = origin;
    }
}
