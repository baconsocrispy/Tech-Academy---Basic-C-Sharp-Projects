using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate Employee 
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // call SayName() method on the employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
