using Lab13.Filters;
using Lab13.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public delegate void ErrorMessageDisplay();


    class Runtime
    {
        public event ErrorMessageDisplay ErrorMessageText;

        public Runtime()
        {
            ErrorMessageText += () => { Console.WriteLine("ERROR! You must enter a choice from menu!"); };
        }



        Ui ui = new Ui();

        public void Start()
        {
            GameManager gameManager = new GameManager();
            bool isMainMenu = true;

            while (isMainMenu)
            {
                ui.MainMenuGfx();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        gameManager.AddGameToList();
                        break;
                    case ConsoleKey.D2:

                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        gameManager.ShowGameList();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        GameFilterMenu();
                        break;
                    case ConsoleKey.D5:
                        isMainMenu = false;
                        break;
                    default:
                        ErrorMessageText.Invoke();
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        public void GameFilterMenu()
        {
            GameManager gameManager = new GameManager();
            bool isGameFilter = true;

            while (isGameFilter)
            {
                ui.FilterListGfx();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        GameListFilter IsGenreFilter = GameFilter.IsGenre;
                        gameManager.PrintFilterResult(IsGenreFilter);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        GameListFilter IsDeveloperFilter = GameFilter.IsDeveloper;
                        gameManager.PrintFilterResult(IsDeveloperFilter);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        GameListFilter IsExpensiveFilter = GameFilter.IsExpensive;
                        gameManager.PrintFilterResult(IsExpensiveFilter);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        GameListFilter IsCheapFilter = GameFilter.IsCheap;
                        gameManager.PrintFilterResult(IsCheapFilter);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D5:
                        isGameFilter = false;
                        break;
                    default:
                        ErrorMessageText.Invoke();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
