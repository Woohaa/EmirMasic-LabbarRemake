using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Runtime
    {
        List<Cat> catList = new List<Cat>();
        List<Shark> sharkList = new List<Shark>();
        List<Eagle> eagleList = new List<Eagle>();

        public void Start()
        {
            MainMenu();
        }

        public void AddAnimal(int input)
        {
            if (input == 1)
            {
                Console.Clear();
                Cat newCat = new Cat();
                Console.WriteLine("Type in the cat name");
                newCat.Name = Console.ReadLine();
                Console.WriteLine("Type in the cat age");
                newCat.Age = int.Parse(Console.ReadLine());
                newCat.CanRun = true;
                Console.WriteLine("Type in the cat breed");
                newCat.Breed = Console.ReadLine();
                newCat.NumberOfLegs = 4;

                catList.Add(newCat);
                
            }
            if (input == 2)
            {
                Console.Clear();
                Shark newShark = new Shark();
                Console.WriteLine("Type in the shark name");
                newShark.Name = Console.ReadLine();
                Console.WriteLine("Type in the shark age");
                newShark.Age = int.Parse(Console.ReadLine());
                newShark.CanSwim = true;
                newShark.BreatheUnderwater = true;
                newShark.IsDangeorous = true;

                sharkList.Add(newShark);
            }
            if (input == 3)
            {
                Console.Clear();
                Eagle newEagle = new Eagle();
                Console.WriteLine("Type in the eagle name");
                newEagle.Name = Console.ReadLine();
                Console.WriteLine("Type in the eagle age");
                newEagle.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Type in the color of the eagle");
                newEagle.Color = Console.ReadLine();
                Console.WriteLine("How high can the eagle fly?");
                newEagle.FlightHeight = int.Parse(Console.ReadLine());
                newEagle.CanFly = true;

                eagleList.Add(newEagle);
            }
        }

        public void RemoveAnimal(int input)
        {
            if (input == 1)
            {
                Console.WriteLine("Chose which cat to remove");
                for (int i = 0; i < catList.Count; i++)
                {
                    Console.WriteLine((i + 1) + " " + catList[i]);
                }
                int removeCat = int.Parse(Console.ReadLine());
                catList.RemoveAt(removeCat - 1);
            }
            if (input == 2)
            {
                Console.WriteLine("Chose which shark to remove");
                for (int i = 0; i < sharkList.Count; i++)
                {
                    Console.WriteLine((i + 1) + " " + sharkList[i]);
                }
                int removeShark = int.Parse(Console.ReadLine());
                sharkList.RemoveAt(removeShark - 1);
            }
            if (input == 3)
            {
                Console.WriteLine("Chose which eagle to remove");
                for (int i = 0; i < eagleList.Count; i++)
                {
                    Console.WriteLine((i + 1) + " " + eagleList[i]);
                }
                int removeEagle = int.Parse(Console.ReadLine());
                eagleList.RemoveAt(removeEagle - 1);
            }
        }

        public void ShowAnimalLists(int input)
        {
            if (input == 1)
            {
                Console.WriteLine("*******************CATS******************");
                foreach (var cat in catList)
                {
                    Console.WriteLine(cat);
                }
            }
            if (input == 2)
            {
                Console.WriteLine("*******************SHARKS******************");
                foreach (var shark in sharkList)
                {
                    Console.WriteLine(shark);
                }
            }
            if (input == 3)
            {
                Console.WriteLine("*******************EAGLES******************");
                foreach (var eagle in eagleList)
                {
                    Console.WriteLine(eagle);
                }
            }
            if (input == 4)
            {
                Console.WriteLine("*******************CATS******************");
                foreach (var cat in catList)
                {
                    Console.WriteLine(cat);
                }
                Console.WriteLine("*******************SHARKS******************");
                foreach (var shark in sharkList)
                {
                    Console.WriteLine(shark);
                }
                Console.WriteLine("*******************EAGLES******************");
                foreach (var eagle in eagleList)
                {
                    Console.WriteLine(eagle);
                }
            }
        }

        public void MainMenuGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Add animal");
            Console.WriteLine("2. Remove animal");
            Console.WriteLine("3. Show animals");
            Console.WriteLine("4. Animal movements and sounds");
            Console.WriteLine("5. Exit");
        }

        public void AddAnimalGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Add cat");
            Console.WriteLine("2. Add shark");
            Console.WriteLine("3. Add eagle");
        }

        public void ShowAnimalsGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Show cats");
            Console.WriteLine("2. Show sharks");
            Console.WriteLine("3. Show eagles");
            Console.WriteLine("4. Show all");
        }

        public void RemoveAnimalGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Remove cats");
            Console.WriteLine("2. Remove sharks");
            Console.WriteLine("3. Remove eagles");
        }

        public void MainMenu()
        {
            bool isMainMenu = true;

            while (isMainMenu)
            {
                MainMenuGfx();
                var inputMenuChoice = Console.ReadKey(true).Key;

                switch (inputMenuChoice)
                {
                    case ConsoleKey.D1:
                        AddAnimalGfx();
                        int inputAdd = int.Parse(Console.ReadLine());
                        AddAnimal(inputAdd);
                        break;
                    case ConsoleKey.D2:
                        RemoveAnimalGfx();
                        int inputRemove = int.Parse(Console.ReadLine());
                        RemoveAnimal(inputRemove);
                        break;
                    case ConsoleKey.D3:
                        ShowAnimalsGfx();
                        int inputShow = int.Parse(Console.ReadLine());
                        ShowAnimalLists(inputShow);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        //Del 1
                        PartOneLab();
                        break;
                    case ConsoleKey.D5:
                        isMainMenu = false;
                        break;
                }
            }
        }


        #region Del 1
        public void PartOneLab()
        {
            Console.Clear();
            Console.WriteLine("CATS");
            Cat cat = new Cat();
            cat.Move();
            cat.AnimalSound();
            Console.WriteLine();
            Console.WriteLine("SHARKS");
            Shark shark = new Shark();
            shark.Move();
            shark.AnimalSound();
            Console.WriteLine(
                );
            Console.WriteLine("EAGLES");
            Eagle eagle = new Eagle();
            eagle.Move();
            eagle.AnimalSound();
            Console.Read();
        }
        #endregion
    }
}
