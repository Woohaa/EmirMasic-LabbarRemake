using Lab7.Interfaces;
using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Managers
{
    class ProductManager
    {
        List<ISellable> storeList = new List<ISellable>
        {
            new Electronics {ProductName = "9D TV", Brand = "LG", Price = 55990.99 },
            new Electronics {ProductName = "Playstation 10", Brand = "Sony", Price = 6999.99 },
            new Electronics {ProductName = "AI Friend", Brand = "Artificial Friends", Price = 855999.00 },
            new Toy {ToyType = "Plush", ProductName = "Peter Griffin Plush", Price = 549.99 },
            new Toy {ToyType = "Plastic Sword", ProductName = "He-Man Sword", Price = 899.99 },
            new Toy {ToyType = "Nerfgun", ProductName = "Nerf Minigun", Price = 1099.00 },
            new Food {ProductName = "Milk", Manufacturer = "Arla", Price = 12.90 },
            new Food {ProductName = "Banana", Manufacturer = "Dole", Price = 19.99 },
            new Food {ProductName = "Sparkling Water", Manufacturer = "Ramlösa", Price = 14.90 },
        };

        public List<ISellable> GetList()
        {
            return storeList;
        }

        public void ShowList()
        {
            foreach (var product in storeList)
            {
                Console.WriteLine(product);
            }
        }
    }
}
