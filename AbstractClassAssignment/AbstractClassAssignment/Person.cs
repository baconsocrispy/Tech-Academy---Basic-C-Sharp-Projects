using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // create an abstract class called Person
    internal abstract class Person
    {
        // create string properties FirstName, LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // give it a method SayName()
        public abstract void SayName();
    }
}
