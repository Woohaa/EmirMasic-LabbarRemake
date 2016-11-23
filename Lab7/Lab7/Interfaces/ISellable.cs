using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Interfaces
{
    interface ISellable
    {
        double Price { get; set; }
        string ProductName { get; set; }
    }
}
