using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4C_Farm_Part_2
{
    class Pig
    {
        private string animalName;
     

        public Pig() => Console.WriteLine("The pig's name was not provided");

        public Pig(string name)
        {
            animalName = name;
            Console.WriteLine($"Hello, my name is {animalName}. ");
        }
        
        public string speak()
        {
            string sound = "Oink";
            return sound;
        }

        public string eat()
        {
            string food = "slop";
            return food;
        }

        public string movie()
        {
            string film = "Animal Farm";
            return film;
        }

        public string product()
        {
            string service = "bacon";
            return service;
        }
    }
}
