using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public abstract void Move();

        public abstract void AnimalSound();
    }
}
