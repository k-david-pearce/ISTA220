using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4A_Farm
{
    class Rabbit
    {
        public Rabbit(string name)
        {
            string animalName = name;
            Console.WriteLine($"Hello, my name is {animalName}. ");
        }

        public string speak()
        {
            string sound = "squeek";
            return sound;
        }

        public string eat()
        {
            string food = "carrots";
            return food;
        }

        public string movie()
        {
            string film = "Roger Rabbit";
            return film;
        }

        public string product()
        {
            string service = "fur";
            return service;
        }
    }
}
