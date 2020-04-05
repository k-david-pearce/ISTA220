using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4C_Farm_Part_2
{
    class Horse
    {
        private string animalName;
        
        public Horse()
        {
            Console.WriteLine("The horse's name was not provided");
        }
        
        public Horse(string name)
        {
            animalName = name;
            Console.WriteLine($"Hello, my name is {animalName}. ");
        }

        public string speak()
        {
            string sound = "neigh";
            return sound;
        }

        public string eat()
        {
            string food = "hay";
            return food;
        }

        public string movie()
        {
            string film = "Black Beauty";
            return film;
        }

        public string product()
        {
            string service = "transportation";
            return service;
        }
    }
}
