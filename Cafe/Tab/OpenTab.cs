using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cafe.Tab
{
    public class OpenTab
    {
        public Guid Id;
        public int TableNumber { get; set; }
        public string Waiter { get; set; }

        public int BookNumber { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
