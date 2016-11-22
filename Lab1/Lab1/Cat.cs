using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Breed: " + Breed;
        }
    }
}
