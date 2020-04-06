using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2A___Calculating_Averages
{
    class Program
    {

        public static int Fib(int n) // Fibonacci sequence
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return Fib(n - 1) + Fib(n - 2);

        }
        static void Main(string[] args)
        {
            int num = 40;

            Console.Write("\n\nRecursive Function: Calculate the Fibonacci number \n");
            Console.Write("----------------------------------------------");
           
            Console.WriteLine("The Fibonacci sequence of {0} is {1}", num, Fib(num));
        }
    }
}