using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Runtime
    {


        static Cat catOne = new Cat() { Name = "OlfDolf", Age = 2, Breed = "Birma" };
        static Cat catTwo = new Cat() { Name = "Pussy", Age = 123, Breed = "Ragdoll" };
        static Cat catThree = new Cat() { Name = "Meow", Age = 41, Breed = "Unknown" };
        static Cat catFour = new Cat() { Name = "Roppo", Age = 7, Breed = "Norwegian" };
        static Cat catFive = new Cat() { Name = "Monika", Age = 4, Breed = "Naked Cat" };

        static List<Cat> catList = new List<Cat>()
            {
                catOne,
                catTwo,
                catThree,
                catFour,
                catFive
            };


        public void Start()
        {

            MainMenu();

            #region Del 1
            //static Cat catOne = new Cat() { Name = "OlfDolf", Age = 2, Breed = "Birma" };
            //static Cat catTwo = new Cat() { Name = "Pussy", Age = 123, Breed = "Ragdoll" };
            //static Cat catThree = new Cat() { Name = "Meow", Age = 41, Breed = "Unknown" };
            //static Cat catFour = new Cat() { Name = "Roppo", Age = 7, Breed = "Norwegian" };
            //static Cat catFive = new Cat() { Name = "Monika", Age = 4, Breed = "Naked Cat" };

            //Console.WriteLine(catOne);
            //Console.WriteLine(catTwo);
            //Console.WriteLine(catThree);
            //Console.WriteLine(catFour);
            //Console.WriteLine(catFive);
            #endregion

            #region Del 2
            //List<Cat> catList = new List<Cat>()
            //{
            //    catOne,
            //    catTwo,
            //    catThree,
            //    catFour,
            //    catFive
            //};

            //foreach (var cat in catList)
            //{
            //    Console.WriteLine(cat);
            //}
            #endregion

        }

        public void ShowMenuGfx()
        {
            Console.WriteLine("1. Add new cat");
            Console.WriteLine("2. Remove cat");
            Console.WriteLine("3. Show cats");
            Console.WriteLine("4.Exit");
        }

        public void ShowCatList()
        {
            for (int i = 0; i < catList.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + catList[i]);
            }
        }

        public void AddCatToList()
        {
            Cat newCat = new Cat();
            Console.WriteLine("Type in cat name");
            newCat.Name = Console.ReadLine();
            Console.WriteLine("Type in cat age");
            newCat.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in cat breed");
            newCat.Breed = Console.ReadLine();

            catList.Add(newCat);
            Console.WriteLine("Cat added to list!");
        }

        public void RemoveCatFromList()
        {
            Console.WriteLine("Chose which cat to remove");
            int input = int.Parse(Console.ReadLine());
            catList.RemoveAt(input - 1);
            Console.WriteLine("Cat removed!");
        }

        public void MainMenu()
        {
            bool isMainMenu = true;

            while (isMainMenu)
            {

                ShowMenuGfx();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        AddCatToList();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        ShowCatList();
                        RemoveCatFromList();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        ShowCatList();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        isMainMenu = false;
                        break;
                }
            }
        }


    }
}
