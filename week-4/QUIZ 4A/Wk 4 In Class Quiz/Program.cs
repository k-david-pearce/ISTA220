using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk_4_In_Class_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> b = new List<int> { 11, 21, 31, 41, 51 };
            demoRefParameter obj = new demoRefParameter();

            Console.WriteLine("b[0] before = {0}", b[0]);
            obj.passByReference(b);
            Console.WriteLine("b[0] after = {0}", b[0]); ;
        }
    }
}
