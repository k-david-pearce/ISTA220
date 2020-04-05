using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q20. Determine GCD or two numbers. Ask user for input.
            try
            {
                int num1, num2;
                int GCD = 0;

                Console.WriteLine("Enter first Integer: ");
                num1 = checked(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Enter second Integer: ");
                num2 = checked(Convert.ToInt32(Console.ReadLine()));

                if (num1 > num2)
                {
                    for (int i = 1; i < num1; i++)
                    {
                        if (num1 % i == 0 && num2 % i == 0)
                        {
                            GCD = i;
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < num2; i++)
                    {
                        if (num1 % i == 0 && num2 % i == 0)
                        {
                            GCD = i;
                        }
                    }
                }

                Console.WriteLine($"The Greatest Common Divisor of {num1} and {num2} is {GCD}");
            }

            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.WriteLine("\nThis program has finally terminated");
            }


        }
    }
}
