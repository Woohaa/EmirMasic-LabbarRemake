using Lab7.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public delegate void ShowWrongInput();

    class Runtime
    {

        public event ShowWrongInput WrongInputMessage;

        ProductManager manager = new ProductManager();
        Ui ui = new Ui();

        public void Start()
        {
            WrongInputMessage += () =>
            {
                Console.WriteLine("Error! Wrong input...");
            };

            bool isRunning = true;

            while (isRunning)
            {
                ui.ShowMenuChoicesGfx();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        ui.ShowAddMenuGfx();
                        Console.WriteLine();
                        int result;
                        bool addInput = int.TryParse(Console.ReadLine(), out result);
                        while (int.TryParse(Console.ReadLine(), out result) == false)
                        Console.WriteLine("Wrong input!");                        
                        manager.AddNewProduct(result);
                        Console.WriteLine("Product added!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        manager.ShowList();
                        Console.WriteLine();
                        Console.WriteLine("Remove product:");
                        int removeInput = int.Parse(Console.ReadLine());
                        manager.RemoveProduct(removeInput);
                        Console.WriteLine("Product deleted!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        manager.ShowList();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        manager.ShowList();
                        Console.WriteLine();
                        Console.WriteLine("Put product in cart");
                        int buyInput = int.Parse(Console.ReadLine());
                        manager.AddToShoppingCart(buyInput);
                        Console.WriteLine("Product added to shoppingcart!");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        manager.ShowShoppingCart();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D6:
                        isRunning = false;
                        break;
                    default:
                        WrongInputMessage.Invoke();
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
