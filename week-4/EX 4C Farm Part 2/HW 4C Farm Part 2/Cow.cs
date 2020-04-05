using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4C_Farm_Part_2
{
    class Cow
    {
        private string animalName;

        public Cow()
        {
            Console.WriteLine("The cow's name was not provided");
        }

        public Cow(string name)
        {
            animalName = name;
            Console.WriteLine($"Hello, my name is {animalName}. ");
        }

        public string speak()
        {
            string sound = "Moo";
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
