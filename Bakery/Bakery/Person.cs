using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        int Age { get; set; }
    }
    class Person : IPerson
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string LastName { get; set; }
       public string MiddleName { get; set; }
       public int Age { get; set; }
       public int BakeryId { get; set; }
    }
}
