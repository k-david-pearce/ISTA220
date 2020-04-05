using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_2_LAB_EX_HW
{
    class Program
    {
        static void AnimalSound(string animal = "duck", string sound = "quack")
        {
            Console.WriteLine($"The {animal} goes \"{sound}\"!");
        }
        static void Main(string[] args)
        {
            string j, k;
            AnimalSound(j = "cow");
        }
    }
}