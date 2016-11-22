using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Eagle: Bird
    {
        public int FlightHeight { get; set; }

        public override void Move()
        {
            Console.WriteLine("The eagle usually circulates at a high altitude.");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Sound: Screeeeeeeeeech.");
        }

        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Color: " + Color + " Can fly: " + CanFly + " Flight Height: " + FlightHeight;
        }
    }
}
