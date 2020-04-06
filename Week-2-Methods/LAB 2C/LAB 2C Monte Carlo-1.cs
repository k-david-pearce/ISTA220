using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_LAB_EX_HW
{
    class Program
    {
        static (double, double) monteCarlo(Random num)
        {
            int a = num.Next(0, 100);
            double x = (double)a / 100.0;
            int b = num.Next(0, 100);
            double y = (double)b / 100.0;
            return (x, y);
        }
        static double hypotenuse(double x, double y)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return (hypotenuse);
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer representing number of iterations: ");
            int iterations = int.Parse(Console.ReadLine());
            Random RNG = new Random();
            int counter = 0;
            for (int i = 0; i < iterations; i++)
            {
                double x, y;
                (x, y) = monteCarlo(RNG);
                double h = hypotenuse(x, y);
                if (h <= 1)
                {
                    counter += 1;
                }
            }
            float estimate = 4 * ((float)counter / (float)iterations);
            double diff = Math.Abs(estimate - Math.PI);
            Console.WriteLine("The estimated value is {0} and the difference is {1}", estimate, diff);
            //10: estimate = 2.8; diff = 0.34
            //100: 3.28; 0.14
            //1000: 3.128; 0.014
            //10000: 3.1512; 0.0096
        }
    }
}
