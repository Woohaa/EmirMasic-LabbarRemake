using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Cat: Mammal
    {
        public string Breed { get; set; }

        public override void Move()
        {
            Console.WriteLine("Cats can run fast, but they also sneak around a lot.");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Sound: MEEEEOOOOOOWWWWWWW.");
        }

        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Breed: " + Breed + " Can run: " + CanRun + " Number of legs: " + NumberOfLegs;
        }
    }
}
