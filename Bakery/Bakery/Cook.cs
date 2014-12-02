using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Cook : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public int BakeryId { get; set; }
    }
}
