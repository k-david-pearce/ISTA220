using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5D
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(int.Parse("17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }

        }
    }
}
