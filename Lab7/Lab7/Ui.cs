using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Ui
    {
        public void ShowMenuChoicesGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Show products");
            Console.WriteLine("4. Buy product");
            Console.WriteLine("5. Show shoppingcart");
            Console.WriteLine("6. Exit");
        }

        public void ShowAddMenuGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Add electronics");
            Console.WriteLine("2. Add Toy");
            Console.WriteLine("3. Add Food");
        }
    }
}
