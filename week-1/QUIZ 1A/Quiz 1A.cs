using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
    {
        int x, y, mySum;
        WriteLine("Enter first number");
        x = Convert.ToInt32(ReadLine());
        WriteLine("Enter second number");
        y = Convert.ToInt32(ReadLine());
        mySum = x + y;
        WriteLine($"Your sum is {mySum}");

        ReadLine(); 
        }
}
}
