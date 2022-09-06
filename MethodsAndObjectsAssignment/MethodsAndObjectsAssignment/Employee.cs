using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    // create Employee class that inherits from Person
    internal class Employee : Person
    {   
        public Employee() { }
        // add Id property of type int
        public int Id { get; set; }
    }
}
