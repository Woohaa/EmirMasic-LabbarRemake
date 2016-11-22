using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Ui
    {
        public void MainMenuGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Add game");
            Console.WriteLine("2. Remove game");
            Console.WriteLine("3. Show Games in list");
            Console.WriteLine("4. Filter games in list");
            Console.WriteLine("5. Exit");
        }


        public void FilterListGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Filter gamelist by RPG");
            Console.WriteLine("2. Filter gamelist by blizzard as developer");
            Console.WriteLine("3. Filter gamelist by most expensive games");
            Console.WriteLine("4. Filter gamelist by the cheapest games");
            Console.WriteLine("5. Exit");
        }
    }
}
