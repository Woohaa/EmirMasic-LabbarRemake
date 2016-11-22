using Lab13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Filters
{
    public delegate bool GameListFilter(Game game);

    class GameFilter
    {
        public static bool IsGenre(Game game)
        {
            game.GameGenre = Genre.RPG;
            return true;
        }

        public static bool IsDeveloper(Game game)
        {
            if (game.Developer == "Blizzard")
                return true;
            else return false;
            
        }

        public static bool IsExpensive(Game game)
        {
            return game.Price > 500;
        }

        public static bool IsCheap(Game game)
        {
            return game.Price < 500;
        }
    }


}
