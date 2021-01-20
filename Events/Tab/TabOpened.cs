using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events.Cafe
{
    public class TabOpened
    {
        public Guid Id;
        public int TableNumber;
        public string Waiter;

        public int BookNumber;
        public string Name;
        public int Phone;
        public string Email;
        public DateTime CheckIn;
        public DateTime CheckOut;
    }
}
