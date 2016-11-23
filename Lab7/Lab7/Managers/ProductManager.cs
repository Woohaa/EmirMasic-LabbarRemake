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

        List<ISellable> shoppingCart = new List<ISellable>();

        public List<ISellable> GetList()
        {
            return storeList;
        }

        public void ShowList()
        {
            for (int i = 0; i < storeList.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + storeList[i]);
            }
        }

        public void AddNewProduct(int input)
        {
            if (input == 1)
            {
                Electronics newElectronic = new Electronics();

                Console.WriteLine("Product name: ");
                newElectronic.ProductName = Console.ReadLine();
                Console.WriteLine("Product brand: ");
                newElectronic.Brand = Console.ReadLine();
                Console.WriteLine("Product price: ");
                newElectronic.Price = double.Parse(Console.ReadLine());

                storeList.Add(newElectronic);
            }

            if (input == 2)
            {
                Toy newToy = new Toy();

                Console.WriteLine("Product name: ");
                newToy.ProductName = Console.ReadLine();
                Console.WriteLine("Product brand: ");
                newToy.ToyType = Console.ReadLine();
                Console.WriteLine("Product price: ");
                newToy.Price = double.Parse(Console.ReadLine());

                storeList.Add(newToy);
            }

            if (input == 3)
            {
                Food newFood = new Food();

                Console.WriteLine("Product name: ");
                newFood.ProductName = Console.ReadLine();
                Console.WriteLine("Product brand: ");
                newFood.Manufacturer = Console.ReadLine();
                Console.WriteLine("Product price: ");
                newFood.Price = double.Parse(Console.ReadLine());

                storeList.Add(newFood);
            }

        }

        public void RemoveProduct(int input)
        {
            storeList.RemoveAt(input - 1);
        }

        public void AddToShoppingCart(int input)
        {

            shoppingCart.Add(storeList[input]);
        
        }

        public void ShowShoppingCart()
        {
            double totalPrice;
            foreach (var product in shoppingCart)
            {
                Console.WriteLine(product);
            }

            totalPrice = shoppingCart.Sum(p => p.Price);
            Console.WriteLine();
            Console.WriteLine("Total price: " + totalPrice);
        }



    }
}
