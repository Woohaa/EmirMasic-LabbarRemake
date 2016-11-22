using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Models
{
    public enum Genre
    {
        RPG = 1,
        RTS,
        MMO,
        Moba,
        Action,
        Platform,
        Puzzle,
        Sport,
        FPS
    }

    public class Game
    {
        public string Name { get; set; }
        public string Developer { get; set; }
        public Genre GameGenre { get; set; }
        public double Price { get; set; }


        public override string ToString()
        {
            return "Game name: " + Name + " Developer studio: " + Developer + " Game genre: " + GameGenre + " Price: " + Price;
        }
    }
}
