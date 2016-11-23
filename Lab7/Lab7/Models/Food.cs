using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Models
{
    class Food: Product
    {
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return "Product: " + ProductName +  " Manufacturer: " + Manufacturer +" Price: " + Price + "kr";
        }
    }
}
