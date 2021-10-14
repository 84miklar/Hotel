using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Rooms
{
    public class Double : Room
    {
        
        public Double(int number, int beds, int price, bool hasChildBed, bool isCleaned)
        {
            Number = number;
            Beds = beds;
            Price = price;
            HasChildBed = hasChildBed;
            IsCleaned = isCleaned;
        }
    }
}
