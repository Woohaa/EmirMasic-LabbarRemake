using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Models
{
    public enum Genre
    {
        Fantasy = 1,
        Scifi,
        Thriller,
        Romance,
        Biography,
        Mystery
    }

     public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public Genre BookGenre { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Title: " + Title + " Genre: " + BookGenre + " Pages: " + Pages + " Price: " + Price + "kr";
        }

    }
}
