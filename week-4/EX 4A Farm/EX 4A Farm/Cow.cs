using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4A_Farm
{
    class Cow
    {
        public Cow(string name)
        {
            string animalName = name;
            Console.WriteLine($"Hello, my name is {animalName}. ");
        }

        public string speak()
        {
            string sound = "moo";
            return sound;
        }

        public string eat()
        {
            string food = "grass";
            return food;
        }

        public string movie()
        {
            string film = "Barnyard";
            return film;
        }

        public string product()
        {
            string service = "beef";
            return service;
        }
    }
}
