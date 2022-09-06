using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // create an employee class
    internal class Employee
    {
        // create Id, FirstName, LastName properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // overload the == to check if employee objects have equal Id properties
        public static bool operator==(Employee employee1, Employee employee2)
        {
            bool equal = employee1.Id == employee2.Id;
            return equal;
        }
        public static bool operator!=(Employee employee1, Employee employee2)
        {
            bool not_equal = employee1.Id != employee2.Id;
            return not_equal;
        }
    }
}
