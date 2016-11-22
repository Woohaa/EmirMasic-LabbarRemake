using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Mammal: Animal
    {
        public int NumberOfLegs { get; set; }
        public bool CanRun { get; set; }

        public override void Move()
        {
            Console.WriteLine("Most mammals run on land and many of em are fast.");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Mammals have a big variety of sounds.");
        }
    }
}
