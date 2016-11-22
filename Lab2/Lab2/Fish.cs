using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Fish: Animal
    {
        public bool CanSwim { get; set; }
        public bool BreatheUnderwater { get; set; }

        public override void Move()
        {
            Console.WriteLine("Fish swim around the water, deep as shallow.");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("The fish sounds are mysterious, some of em let out sounds, other is unknown.");
        }
    }
}
