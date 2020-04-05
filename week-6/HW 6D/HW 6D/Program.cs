using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6D
{
    class Program
    {
        static void Main(string[] args)
        {
            var homework = new Hw6d(1, "Lee");
            var (hwNum, hwString) = homework;
            Console.WriteLine($"{hwNum}, {hwString}");
        }
    }
}
