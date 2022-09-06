using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    // create a class called Person
    public class Person
    {
        // give it string properties FirstName/LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // create void method SayName() the writes full name to console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
