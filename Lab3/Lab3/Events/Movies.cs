using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Events
{
    public enum Genre
    {
        Fantasy = 1,
        Scifi,
        Horror,
        Drama,
        Comedy,
        Thriller,
        Biography
    }

    class Movies: Ticket
    {
        public int MovieRuntime { get; set; }
        public Genre MovieGenre { get; set; }

        public override string ToString()
        {
            return "Movie name: " + EventName + " Event Type: " + EventType + " Movie genre: " + MovieGenre + " Date: " + DateAndTime + " Runtime: " + MovieRuntime + " Price: " + Price + "kr";
        }
    }
}
