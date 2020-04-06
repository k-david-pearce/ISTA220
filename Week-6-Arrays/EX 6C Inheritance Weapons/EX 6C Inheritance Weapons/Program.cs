using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6C_Inheritance_Weapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firing Small weapon: ");
            SmallCaliberWeapon myHandgun = new SmallCaliberWeapon();
            myHandgun.Handgunload();
            myHandgun.StartFiring("Fire in the hole");

            Console.WriteLine("\nFiring Artillery");
            InDirectFireMethod myArtillery = new InDirectFireMethod();
            myArtillery.Howitzerload();
            myArtillery.StartFiring("Take Cover");

            Console.WriteLine("\nFiring Missiles");
            DirectFireMethod myHellfire = new DirectFireMethod();
            myHellfire.Hellfireload();
            myHellfire.StartFiring("Warheads on Foreheads");

            Console.WriteLine("\nTesting polymorphism");
            Weapon w = myHandgun;
            w.Fire();
            w = myArtillery;
            w.Fire();
            w = myHellfire;
            w.Fire();
        }
    }
}
