using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Bird: Animal
    {
        public bool CanFly { get; set; }
        public string Color { get; set; }

        public override void AnimalSound()
        {
            Console.WriteLine("Most birds have a special sound beautiful ones, as very annoying ones.");
        }

        public override void Move()
        {
            Console.WriteLine("Most birds fly.");
        }
    }
}
