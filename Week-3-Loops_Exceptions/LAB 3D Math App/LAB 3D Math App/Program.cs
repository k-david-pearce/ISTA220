﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3D_Math_App
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                string firstNum, secondNum;

                Console.WriteLine("Please enter a mathematical operarator (* / + - %) or type anything else to exit");
                string userInput = Console.ReadLine();

                if (userInput != "*" && userInput != "/" && userInput != "+" && userInput != "-")
                {
                    throw new Exception("\nThanks for stopping by!");
                }

                Console.Write("Please enter your first number: ");
                firstNum = Console.ReadLine();
                Console.Write("\nPlease enter your second number: ");
                secondNum = Console.ReadLine();

                while (userInput == "/" && secondNum == "0")
                {
                    Console.Write("You cannot divide by 0. Enter another divisor: ");
                    secondNum = Console.ReadLine();
                }

                switch (userInput)
                {
                    case "*":
                        Console.WriteLine($"{firstNum} * {secondNum} = {multiplyNums(firstNum, secondNum)}");
                        break;

                    case "/":
                        Console.WriteLine($"{firstNum} / {secondNum} = {divideNums(firstNum, secondNum)}");
                        break;

                    case "+":
                        Console.WriteLine($"{firstNum} + {secondNum} = {addNums(firstNum, secondNum)}");
                        break;

                    case "-":
                        Console.WriteLine($"{firstNum} - {secondNum} = {subtractNums(firstNum, secondNum)}");
                        break;

                    default:
                        Console.WriteLine("\nOperation not possible");
                        break;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            double multiplyNums(string num1, string num2)
            {
                double first = double.Parse(num1);
                double second = double.Parse(num2);
                double answer = first * second;
                return answer;
            }
            double divideNums(string num1, string num2)
            {
                double first = double.Parse(num1);
                double second = double.Parse(num2);
                double answer = first / second;
                return answer;
            }
            double addNums(string num1, string num2)
            {
                double first = double.Parse(num1);
                double second = double.Parse(num2);
                double answer = first + second;
                return answer;
            }
            double subtractNums(string num1, string num2)
            {
                double first = double.Parse(num1);
                double second = double.Parse(num2);
                double answer = first - second;
                return answer;
            }
        }
    }
}
