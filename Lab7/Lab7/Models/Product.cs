using Lab7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Models
{
    class Product : ISellable
    {
        public double Price { get; set; }

        public string ProductName { get; set; }

    
    }
}
