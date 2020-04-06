using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6D
{
    class Hw6d
    {
        public int fieldInt;
        private string fieldString;

        public Hw6d() // default constructor
        {
            Console.WriteLine("This is the default constructor for Homework 6D");
        }

        public Hw6d(int param1, string param2)
        {
            this.fieldInt = param1;
            this.fieldString = param2;
        }

        public void Deconstruct(out int fieldInt, out string fieldString)
        {
            fieldInt = this.fieldInt;
            fieldString = this.fieldString;
        }
    }
}
