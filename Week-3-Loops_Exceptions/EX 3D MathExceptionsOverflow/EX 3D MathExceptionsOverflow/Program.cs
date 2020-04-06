using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EX_3D_MathExceptionsOverflow
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

                rt = getInt();

                circ = 2 * Math.PI * rt;
                area = Math.PI * Math.Pow(rt, 2);
                WriteLine($"The circumference is {circ}");
                WriteLine($"The area is {area}");

                // Volume of a Hemisphere
                WriteLine("\nThis will calculate the Volume of a Hemisphere\n");
                int rh;
                double vol_hem;

                rh = getInt();

                vol_hem = (4 / 3 * Math.PI * Math.Pow(rh, 3) / 2);
                WriteLine("The volume of the hemisphere is {0}", vol_hem);

                // Area of a Triangle
                WriteLine("\nThis will calculate the Area of a Triangle\n");
                double area_tri;
                double p;
                int sideA = getInt();
                int sideB = getInt();
                int sideC = getInt();

                p = (sideA + sideB + sideC) / 2;
                area_tri = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                WriteLine($"The area of the triangle is {area_tri}");

                //Quadratic Equation
                WriteLine("\nThis will solve a Quadratic Equation\n");
                int a = getInt();
                int b = getInt();
                int c = getInt();
                double d;
                double x1;
                double x2;
                
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

                int getInt()
                {
                    int num = 0;
                    while (num <= 0)
                    {
                        try
                        {
                            WriteLine("Enter an integer: ");
                            num = checked(Convert.ToInt32(ReadLine()));

                            if (num <= 0)
                            {
                                throw new Exception("Input cannot be less than or equal to zero.");
                            }
                        }
                        catch (FormatException fExRad)
                        {
                            Console.WriteLine("You must enter a valid number");
                        }
                        catch (Exception Ex)
                        {
                            Console.WriteLine(Ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Okay");
                        }
                    }
                    return num;
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
                Console.WriteLine("Okay");
            } 
        }
    }
}
