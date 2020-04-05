using System;
using static System.Console;

namespace EX_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Circumference and Area of a Circle
                WriteLine("This will calculate the Area and Circumference of a Circle\n");
                int rt;
                double circ;
                double area;
                WriteLine("Enter radius");
                rt = checked(Convert.ToInt32(ReadLine()));

                if (rt <= 0)
                {
                    throw new Exception("Input cannot be less than or equal to zero.");
                }

                circ = 2 * Math.PI * rt;
                area = Math.PI * Math.Pow(rt, 2);
                WriteLine($"The circumference is {circ}");
                WriteLine($"The area is {area}");

                // Volume of a Hemisphere
                WriteLine("\nThis will calculate the Volume of a Hemisphere\n");
                int rh;
                double vol_hem;
                WriteLine("Enter radius");
                rh = checked(Convert.ToInt32(ReadLine()));

                if (rh <= 0)
                {
                    throw new Exception("Input cannot be less than or equal to zero.");
                }

                vol_hem = (4 / 3 * Math.PI * Math.Pow(rh, 3) / 2);
                WriteLine("The volume of the hemisphere is {0}", vol_hem);

                // Area of a Triangle
                WriteLine("\nThis will calculate the Area of a Triangle\n");
                double area_tri;
                double p;
                int sideA;
                int sideB;
                int sideC;
                WriteLine("Enter side A of triangle");
                sideA = checked(Convert.ToInt32(ReadLine()));
                WriteLine("Enter side B of triangle");
                sideB = checked(Convert.ToInt32(ReadLine()));
                WriteLine("Enter side C of triangle");
                sideC = checked(Convert.ToInt32(ReadLine()));

                if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                {
                    throw new Exception("Input cannot be less than or equal to zero.");
                }

                p = (sideA + sideB + sideC) / 2;
                area_tri = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                WriteLine($"The area of the triangle is {area_tri}");

                //Quadratic Equation
                WriteLine("\nThis will solve a Quadratic Equation\n");
                int a;
                int b;
                int c;
                double d;
                double x1;
                double x2;
                WriteLine("Enter quadratic coefficient a");
                a = checked(Convert.ToInt32(ReadLine()));
                WriteLine("Enter linear coefficient b");
                b = checked(Convert.ToInt32(ReadLine()));
                WriteLine("Enter constant c");
                c = checked(Convert.ToInt32(ReadLine()));
                d = Math.Pow(b, 2) - 4 * a * c;

                if (d == 0)
                {
                    x1 = -b / (2 * a); // one real solution
                    Console.WriteLine("One real solution: {0}", x1);
                }
                else if (d < 0)
                {
                    throw new InvalidOperationException("no real solution. d < 0");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Two real solutions: {0}, {1}", x1, x2);
                }
            }
            
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            
            catch (DivideByZeroException dbzEx)
            {
                Console.WriteLine(dbzEx.Message);
            }

            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.WriteLine("This program has finally terminated");
            }
            

            
                
            


            //// Pop Quiz 2
            //int numOne, numTwo;
            //WriteLine("Enter first number");
            //numOne = Convert.ToInt32(ReadLine());
            //WriteLine("Enter second number");
            //numTwo = Convert.ToInt32(ReadLine());

            //if (numOne > numTwo)
            //{
            //    WriteLine($"{numOne} is the larger number");
            //}
            //else if (numOne < numTwo)
            //{
            //    WriteLine($"{numTwo} is the larger number");
            //}
            //else
            //    WriteLine("Both numbers are the same");

            //ReadLine();
        }
    }
}
