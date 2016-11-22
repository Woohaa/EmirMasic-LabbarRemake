using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Ui
    {
        Runtime runtime = new Runtime();


        public void MainMenuGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Book tickets");
            Console.WriteLine("2. Show Events");
            Console.WriteLine("3. Ticket info");
            Console.WriteLine("4. Exit");

        }

        public void BookTicketGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Book Concert tickets");
            Console.WriteLine("2. Book Festival tickets");
            Console.WriteLine("3. Book Movie tickets");
            Console.WriteLine("4. Exit");
        }

        public void ShowEventInfoGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Show concerts");
            Console.WriteLine("2. Show festivals");
            Console.WriteLine("3. Show movies");
            Console.WriteLine("4. Exit");
        }

        public void ShowBookedEventInfoGfx()
        {
            Console.Clear();
            Console.WriteLine("1. Show booked concerts");
            Console.WriteLine("2. Show booked festivals");
            Console.WriteLine("3. Show booked movies");
            Console.WriteLine("4. Exit");
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
                        BookTicketMenu();
                        break;
                    case ConsoleKey.D2:
                        ShowEventMenu();
                        break;
                    case ConsoleKey.D3:
                        BookedEventsMenu();
                        break;
                    case ConsoleKey.D4:
                        isMainMenu = false;
                        break;
                }
            }
        }

        public void BookTicketMenu()
        {
            bool isBookMenu = true;

            while (isBookMenu)
            {
                BookTicketGfx();
                var bookInput = Console.ReadKey(true).Key;

                switch (bookInput)
                {
                    case ConsoleKey.D1:
                        runtime.ShowConcertLists();
                        Console.WriteLine();
                        Console.WriteLine("Type in name you are booking with");
                        string whoBookedConcert = Console.ReadLine();
                        Console.WriteLine("Pick which concert you want to book");
                        int bookConcert = int.Parse(Console.ReadLine());
                        runtime.BookConcertEvent(whoBookedConcert , bookConcert);
                        break;
                    case ConsoleKey.D2:
                        runtime.ShowFestivalLists();
                        Console.WriteLine();
                        Console.WriteLine("Type in name you are booking with");
                        string whoBookedFestival = Console.ReadLine();
                        Console.WriteLine("Pick which festival you want to book");
                        int bookFestival = int.Parse(Console.ReadLine());
                        runtime.BookFestivalEvent(whoBookedFestival, bookFestival);
                        break;
                    case ConsoleKey.D3:
                        runtime.ShowMovieLists();
                        Console.WriteLine();
                        Console.WriteLine("Type in name you are booking with");
                        string whoBookedMovie = Console.ReadLine();
                        Console.WriteLine("Pick which movie you want to book");
                        int bookMovie = int.Parse(Console.ReadLine());
                        runtime.BookMovieEvent(whoBookedMovie, bookMovie);
                        break;
                    case ConsoleKey.D4:
                        isBookMenu = false;
                        break;
                }
            }
        }

        public void ShowEventMenu()
        {
            bool isShowEventMenu = true;

            while (isShowEventMenu)
            {
                ShowEventInfoGfx();
                var showInput = Console.ReadKey(true).Key;

                switch (showInput)
                {
                    case ConsoleKey.D1:
                        runtime.ShowConcertLists();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        runtime.ShowFestivalLists();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        runtime.ShowMovieLists();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        isShowEventMenu = false;
                        break;

                }
            }
        }

        public void BookedEventsMenu()
        {
            bool isBookedEvents = true;

            while (isBookedEvents)
            {
                ShowBookedEventInfoGfx();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        runtime.ShowBookedConcerts();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        runtime.ShowBookedFestivals();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        runtime.ShowBookedMovies();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D4:
                        isBookedEvents = false;
                        break;
                }
            }
        }
    }
}
