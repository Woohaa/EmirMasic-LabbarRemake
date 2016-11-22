using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Events
{
    class Concerts: Ticket
    {
        public string Band { get; set; }

        public override string ToString()
        {
            return "Band: " + Band + " Event Name: " + EventName + " Event Type: " + EventType +  " Date: " + DateAndTime + " Price: " + Price + "kr";
        }
    }
}
