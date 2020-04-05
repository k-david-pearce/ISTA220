using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_2_LAB_EX_HW
{
    class Program
    {
        // Q3: Describe "Synthetic Sugar" in your own words.

        // Optional parameters are "Syntatic Sugar" because in one method 
        // I have created the ability to call 0, 1, or 2 parameters and return
        // default values or specific values. Compare this to overloaded functions,
        // which allows two identifiers to have same name but is not as versatile
        // as optional parameters since default values are not always automatic.

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // Q1: Write a method that takes two optional parameters

        static void AnimalSound(string animal = "cow", string sound = "moo")
        {
            Console.WriteLine($"Q1: The {animal} goes \"{sound}\"!");
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // Q2: Write out overloaded functions of the optional parameters.

        static void soundOfAnimal()
        {
            Console.WriteLine($"Q2: The cow goes moo!");
        }
        static void soundOfAnimal(string animal)
        {
            Console.WriteLine($"Q2: The {animal} goes moo!");
        }
        static void soundOfAnimal(string animal, string sound)
        {
            Console.WriteLine($"Q2: The {animal} goes \"{sound}\"!");
        }

        static void Main(string[] args)
        {
            AnimalSound();  // Q1
            soundOfAnimal("cow");  // Q2
            Console.WriteLine("Q3: Describe \"Synthetic Sugar\" in your own words. " +
                "\nOptional parameters are \"Syntatic Sugar\" because in one " +
                "\nmethod I have created the ability to call 0, 1, or 2 parameters " +
                "\nand return default values or specific values. Compare this to overloaded functions, " +
                "\nwhich allows two identifiers to have same name but is not as versatile as optional " +
                "\nparameters since default values are not always automatic.");
        }
    }
}