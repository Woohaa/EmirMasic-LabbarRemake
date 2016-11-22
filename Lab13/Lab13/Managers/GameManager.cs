using Lab13.Filters;
using Lab13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Managers
{
    class GameManager
    {
        List<Game> gameList = new List<Game>
        {
            new Game {Name = "World of Warcraft: Legion", Developer = "Blizzard", GameGenre = Genre.MMO, Price = 399.99 },
            new Game {Name = "Mass Effect 4: Andromeda", Developer = "Bioware", GameGenre = Genre.RPG, Price = 799.99 },
            new Game {Name = "Xenogears", Developer = "Squaresoft", GameGenre = Genre.RPG, Price = 1699.99 },
            new Game {Name = "Mario Kart U", Developer = "Nintendo", GameGenre = Genre.Sport, Price = 499.99 },
            new Game {Name = "World of Warcraft", Developer = "Blizzard", GameGenre = Genre.MMO, Price = 99.99 },
            new Game {Name = "Heroes of the Storm", Developer = "Blizzard", GameGenre = Genre.Moba, Price = 0 },
            new Game {Name = "Star Wars Old Republic", Developer = "Bioware", GameGenre = Genre.MMO, Price = 299.99 },
            new Game {Name = "Skyrim: Collectors Edition", Developer = "Bethesda", GameGenre = Genre.RPG, Price = 999.99 },
            new Game {Name = "Fallout 2", Developer = "Black Isle Studios", GameGenre = Genre.RPG, Price = 99.99 },
            new Game {Name = "Cities: Skyline", Developer = "Paradox", GameGenre = Genre.RTS, Price = 349.99 },
        };

        public void AddGameToList()
        {
            Game newGame = new Game();
            Console.WriteLine("Type in game name");
            newGame.Name = Console.ReadLine();
            Console.WriteLine("Type in developer studio");
            newGame.Developer = Console.ReadLine();
            Console.WriteLine("Choose genre");
            int result;
            bool input =  int.TryParse(Console.ReadLine(), out result);
            if(input == true)
            {
                newGame.GameGenre = (Genre)result;
            }
            else
            {
                Console.WriteLine("Wrong key!");
            }
            Console.WriteLine("Type in the price of the game");
            double priceResult;
            bool priceInput = double.TryParse(Console.ReadLine(), out priceResult);
            if(priceInput == true)
            {
                newGame.Price = priceResult;
            }
            gameList.Add(newGame);
            Console.WriteLine("Game added!");

        }

        public void ShowGameList()
        {
            for (int i = 0; i < gameList.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + gameList[i]);
            }
        }

        public void PrintFilterResult(GameListFilter filter)
        {
            foreach (var game in gameList)
            {
                if (filter(game))
                    Console.WriteLine(game);
            }
        }
    }
}
