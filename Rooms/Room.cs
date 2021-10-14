using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Rooms
{
    public abstract class Room
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int Beds { get; set; }
        public bool HasChildBed { get; set; }
        public bool IsCleaned { get; set; }

    }
}
