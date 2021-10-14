using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public class Massage : Health
    {
        public int Length { get; set; }
        public string Therapist { get; set; }
        public string Type { get; set; }
    }
}
