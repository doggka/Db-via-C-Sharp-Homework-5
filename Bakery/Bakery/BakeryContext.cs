using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class BakeryContext : DbContext
    {
        public IDbSet<Bakery> Bakeries { get; set; }
        public IDbSet<Person> People { get; set; }
        public IDbSet<Cook> Cooks { get; set; }
        public IDbSet<Bulka> Bulki { get; set; } 
 
 
    }
}
