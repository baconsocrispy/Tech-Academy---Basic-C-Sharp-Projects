using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.Quit();
        }
    }
}
