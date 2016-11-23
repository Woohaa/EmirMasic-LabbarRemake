using Lab7.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Runtime
    {
        ProductManager manager = new ProductManager();

        public void Start()
        {
            manager.ShowList();

            Console.ReadLine();
        }
    }
}
