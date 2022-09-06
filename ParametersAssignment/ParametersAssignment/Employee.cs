using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    internal class Employee<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<T> things { get; set; }

        public Employee()
        {
            things = new List<T>();
        }

    }
}