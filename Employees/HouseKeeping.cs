using Hotel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Employees
{
    public class HouseKeeping : IEmployee, IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }
    }
}
