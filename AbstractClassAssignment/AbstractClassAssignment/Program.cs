using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate an Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // call the SayName() method on the object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
