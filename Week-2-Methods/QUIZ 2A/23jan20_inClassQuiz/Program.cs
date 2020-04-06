using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23jan20_inClassQuiz
{
    class Program
    {
        public static void quadEq(double a, double b, double c)
        {            
            double x1;
            double x2;
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d == 0)
            {
                x1 = -b / (2 * a); // one real solution
                Console.WriteLine("One real solution: {0}", x1);
            }
            else if (d < 0)
            {
                Console.WriteLine("No real solution");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Two real solutions: {0}, {1}", x1, x2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nThis will solve a Quadratic Equation\n");

            Console.WriteLine("Enter quadratic coefficient a");
            double coeff_a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter linear coefficient b");
            double coeff_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter constant c");
            double const_c = Convert.ToDouble(Console.ReadLine());

            quadEq(coeff_a, coeff_b, const_c);
        }
    }
}
