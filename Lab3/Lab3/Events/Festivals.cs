using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Events
{
    class Festivals: Ticket
    {
        public string FestivalType { get; set; }
        public int NumberOfDays { get; set; }

        public override string ToString()
        {
            return "Festival Type: " + FestivalType + " Event Name: " + EventName + " Event Type: " + EventType + " Date:" + DateAndTime + "Festival length" + NumberOfDays + " Price: " + Price + "kr";
        }
    }
}
