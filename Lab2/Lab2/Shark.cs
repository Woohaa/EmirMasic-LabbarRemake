using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Shark: Fish
    {
        public bool IsDangeorous { get; set; }

        public override void Move()
        {
            Console.WriteLine("The shark swims at pretty shallow water");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Sound: Blub blub.");
        }

        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Can swim: " + CanSwim + " Breathe underwater: " + BreatheUnderwater + " Is Dangerous: " + IsDangeorous;
        }
    }
}
