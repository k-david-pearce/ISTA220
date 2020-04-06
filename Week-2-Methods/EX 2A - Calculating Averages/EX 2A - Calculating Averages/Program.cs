using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2A___Calculating_Averages
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("This application will accept test scores between 0 and 100, then report their average and letter grade\n");
            int count = 0;
            int numSum = 0;
            double numAvg = 0;
            string userInput;
            int numGrade;

            Console.WriteLine("Enter a test score. If finished hit 'enter'");
            userInput = Console.ReadLine();

            while (int.TryParse(userInput, out numGrade))
            {
                while (numGrade < 0)
                {
                    Console.WriteLine("Your number must be greater than 0");
                    numGrade = int.Parse(Console.ReadLine());
                    while (numGrade > 100)
                    {
                        Console.WriteLine("Your number must be less than 100");
                        numGrade = int.Parse(Console.ReadLine());
                    }
                }
                while (numGrade > 100)
                {
                    Console.WriteLine("Your number must be less than 100");
                    numGrade = int.Parse(Console.ReadLine());
                    while (numGrade < 0)
                    {
                        Console.WriteLine("Your number must be greater than 0");
                        numGrade = int.Parse(Console.ReadLine());
                    }
                }
                numSum += numGrade;
                count += 1;
                Console.WriteLine("Enter a test score. If finished hit 'enter'");
                userInput = Console.ReadLine();
            }

            numAvg = numSum / count;
            if (numAvg >= 90)
            {
                Console.WriteLine("The numerical average is {0} and the letter grade is A", numAvg);
            }
            else if (numAvg >= 80)
            {
                Console.WriteLine("The numerical average is {0} and the letter grade is B", numAvg);
            }
            else if (numAvg >= 70)
            {
                Console.WriteLine("The numerical average is {0} and the letter grade is C", numAvg);
            }
            else if (numAvg < 70)
            {
                Console.WriteLine("The numerical average is {0} and the letter grade is F", numAvg);
            }
        }
    }
}
