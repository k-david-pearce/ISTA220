using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk_4_In_Class_Quiz
{
    class demoRefParameter
    {
        // create method called passbyref with parameter list and variable b
        public void passByReference(List<int> b)
        {
            b[0] = 5;
           
            Console.WriteLine("b[0] inside method = {0}", b[0]);
        }
        

    }
}
