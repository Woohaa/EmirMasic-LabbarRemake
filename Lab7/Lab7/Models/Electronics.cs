﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Models
{
    class Electronics: Product
    {
        public string Brand { get; set; }

        public override string ToString()
        {
            return  "Product: " + ProductName + "Brand: " + Brand + " Price: " + Price + "kr";
        }
    }
}
