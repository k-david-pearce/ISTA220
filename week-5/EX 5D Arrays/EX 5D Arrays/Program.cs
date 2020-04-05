using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This is EX 5D\n");
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            getSum(A);
            getSum(B);
            getSum(C);
            Console.WriteLine($"\n");
            getReverse(A);
            getReverse(B);
            getReverse(C);
            Console.WriteLine($"\n");
            rotate(A, 2, "L");
            rotate(B, 2, "R");
            rotate(C, 4, "L");
            Console.WriteLine($"\n");
            getSort(C);
        }
        private static void getSum(int[] set)
        {
            double sum = 0;
            for (int i = 0; i < set.Length; i++)
            {
                sum += set[i];
            }
            double avg = sum / set.Length;
            Console.WriteLine($"The Sum of the array is: {sum} and the Average is: {avg}");
        }

        private static void getReverse(int[] game)
        {
            Console.WriteLine($"The reverse order of the array is: ");
            for (int y = game.Length - 1; y >= 0; y--)
            {
                Console.Write($"{game[y]}, ");
            }
            Console.WriteLine($"\n");
        }

        private static void rotate(int[] match, int pos, string direction)
        {
            if (direction == "R")
            {
                rotateRight(match, pos);
            }
            else if (direction == "L")
            {
                rotateLeft(match, pos);
            }
        }
        private static void rotateRight(int[] match, int pos)
        {
            Console.WriteLine($"The array was rotated right {pos}");
            int[] temp = new int[match.Length];
            int len = match.Length;
            for (int i = 0; i < pos; i++)
                temp[i] = match[len - pos + i];
            for (int i = pos; i < len; i++)
                temp[i] = match[i - pos];
            foreach (int rotated in temp)
                Console.Write($"{rotated}, ");
            Console.WriteLine($"\n");
        }
        private static void rotateLeft(int[] match, int pos)
        {
            Console.WriteLine($"The array was rotated left {pos}");
            int[] temp = new int[match.Length];
            int len = match.Length;
            for (int i = 0; i < len - pos; i++)
                temp[i] = match[pos + i];
            for (int i = len - pos; i < len; i++)
                temp[i] = match[i + pos - len];
            foreach (int rotated in temp)
                Console.Write($"{rotated}, ");
            Console.WriteLine($"\n");
        }
        private static void getSort(int[] sorted)
        {
            Console.WriteLine($"The array was sorted");
            int len = sorted.Length;
            for (int current = 0; current < len - 1; current++)
                for (int currentTest = current + 1; currentTest < len; currentTest++)
                    if (sorted[current] > sorted[currentTest])
                    {
                        int temp = sorted[currentTest];
                        sorted[currentTest] = sorted[current];
                        sorted[current] = temp;
                    }

            foreach (int sort in sorted)
                Console.Write($"{sort} ");
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EX_5D_Arrays
//{
//    class Program
//    {
//        public double arrayAvg(int[] myArray)
//        {
//            int count = myArray.Length;
//            int sum = myArray.Sum();
//            double avg = sum / count;
//            return avg;
//        }

//        public void reverseArray(int[] myArray)
//        {
//            //for (int i = 0; i < myArray.Length / 2; i++)
//            //{
//            //    int temp = myArray[i];
//            //    myArray[i] = myArray[myArray.Length - 1 - i];
//            //    myArray[myArray.Length - 1 - i] = temp;
//            //}
//            foreach (int num in myArray.Reverse())
//            {
//                Console.WriteLine(num);
//            }
//        }

//        public static void rotateArray(string shiftDirection, int numSpaces, int[] myArray)
//        {
//            if (shiftDirection == "right")
//            {
//                for (int i = 0; i < myArray.Length; i++)
//                {
//                    if (i + numSpaces > myArray.Length - 1)
//                    {
//                        int temp1 = myArray[i];
//                        myArray[i] = myArray[(i + numSpaces)-(myArray.Length)];
//                        if (i - numSpaces >= 0)
//                        {
//                            myArray[i - numSpaces] = temp1;
//                        }
//                        else
//                        {
//                            myArray[(i - numSpaces) + (myArray.Length - 1)] = temp1;
//                        }

//                    }
//                    else
//                    {
//                        int temp2 = myArray[i];
//                        myArray[i] = myArray[i + numSpaces];
//                        if (i - numSpaces >= 0)
//                        {
//                            myArray[i - numSpaces] = temp2;
//                        }
//                        else
//                        {
//                            myArray[(i - numSpaces) + (myArray.Length - 1)] = temp2;
//                        }
//                    }
//                }
//            }
//            foreach (int num in myArray)
//            {
//                Console.WriteLine(num);
//            }
//        }



//        static void Main(string[] args)
//        {
//            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
//            int[] ArrayB = { 1, 3, 5, 7, 9 };
//            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

//            rotateArray("right", 2, ArrayA);
//        }
//    }
//}
