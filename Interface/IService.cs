using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public interface IService
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
