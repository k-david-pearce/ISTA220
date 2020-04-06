using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4C_Farm_Part_2
{
    class Chicken
    {
        private string animalName;

        public Chicken()
        {
            Console.WriteLine("The cow's name was not provided");
        }

        public Chicken(string name)
        {
            animalName = name;
            Console.WriteLine($"Hello, my name is {animalName}. ");
        }

        public string speak()
        {
            string sound = "Cluck";
            return sound;
        }

        public string eat()
        {
            string food = "corn";
            return food;
        }

        public string movie()
        {
            string film = "Chicken Little";
            return film;
        }

        public string product()
        {
            string service = "BBQ wings";
            return service;
        }
    }
}
