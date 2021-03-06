﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6C_Inheritance_Weapons
{
    class Weapon
    {
        public void StartFiring(string firingNoise)
        {
            Console.WriteLine($"Firing weapon: {firingNoise}");
        }
        
        public virtual void Fire()
        {
            Console.WriteLine("Default: Firing weapon");
        }
    }

    class SmallCaliberWeapon : Weapon
    {
        public void Handgunload()
        {
            Console.WriteLine("Loading Colt 45");
        }

        public override void Fire()
        {
            Console.WriteLine("Firing small weapons");
        }
    }

    class DirectFireMethod : Weapon
    {
        public void Hellfireload()
        {
            Console.WriteLine("loading Hellfire");
        }

        public override void Fire()
        {
            Console.WriteLine("Firing Hellfire Missiles");
        }
    }

    class InDirectFireMethod : Weapon
    {
        public void Howitzerload()
        {
            Console.WriteLine("loading Howitzer");
        }

        public override void Fire()
        {
            Console.WriteLine("Firing Artillery Weapons");
        }
    }
}
