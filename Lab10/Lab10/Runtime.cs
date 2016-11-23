using Lab10.Filters;
using Lab10.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public delegate void ShowWrongInputMessage();

    class Runtime
    {

        public event ShowWrongInputMessage WrongInputErrorText;

        public Runtime()
        {
            WrongInputErrorText += () => { Console.WriteLine("You must press a button available in list!!!"); };
        }

        Ui ui = new Ui();

        public void Start()
        {
            BookManager bookManager = new BookManager();
            bool isRunning = true;

            while (isRunning)
            {
                ui.MenuChoiceGfx();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        BookFilter IsNovel = new BookFilter(BookFilters.IsNovel);
                        bookManager.PrintWhere(IsNovel);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        BookFilter IsShortStory = new BookFilter(BookFilters.IsShortStory);
                        bookManager.PrintWhere(IsShortStory);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        BookFilter IsMystery = new BookFilter(BookFilters.IsGenreMystery);
                        bookManager.PrintWhere(IsMystery);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        BookFilter IsFantasy = new BookFilter(BookFilters.IsGenreFantasy);
                        bookManager.PrintWhere(IsFantasy);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D5:
                        BookFilter IsRomance = new BookFilter(BookFilters.IsGenreRomance);
                        bookManager.PrintWhere(IsRomance);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D6:
                        BookFilter IsCheap = new BookFilter(BookFilters.IsCheap);
                        bookManager.PrintWhere(IsCheap);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D7:
                        BookFilter IsExpensive = new BookFilter(BookFilters.IsExpensive);
                        bookManager.PrintWhere(IsExpensive);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D8:
                        isRunning = false;
                        break;
                    default:
                        WrongInputErrorText.Invoke();
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
