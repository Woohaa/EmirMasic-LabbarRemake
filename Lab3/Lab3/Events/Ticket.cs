using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Events
{
    public enum EventType
    {
        Concert = 1,
        Festival,
        Movie
    }

    class Ticket
    {
        public string BookerName { get; set; }
        public string EventName { get; set; }
        public EventType EventType { get; set; }
        public DateTime DateAndTime { get; set; }
        public decimal Price { get; set; }

    }
}
