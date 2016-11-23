using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Models
{
    class Toy: Product
    {
        public string ToyType { get; set; }

        public override string ToString()
        {
            return "Product: " + ProductName + " Toy type: " + ToyType + " Price: " + Price + "kr";
        }
    }
}
