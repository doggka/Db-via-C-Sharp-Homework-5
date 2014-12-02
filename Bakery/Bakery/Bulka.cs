using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
     public class Bulka
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Taste { get; set; }
        public int Cost { get; set; }
        public ICollection<Bakery> Bakeries { get; set; } 
    }
}
