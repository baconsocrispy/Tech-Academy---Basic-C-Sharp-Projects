using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate an Employee object with string as generic parameter
            Employee<string> employee1 = new Employee<string>();

            // instantiate an Employee object with int as generic parameter
            Employee<int> employee2 = new Employee<int>();

            // assign strings/ints to list parameters
            employee1.things.Add("thing1");
            employee1.things.Add("thing2");
            employee1.things.Add("thing3");

            employee2.things.Add(10);
            employee2.things.Add(20);
            employee2.things.Add(30);

            // create a loop that prints all things to console
            foreach (string thing in employee1.things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee2.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
