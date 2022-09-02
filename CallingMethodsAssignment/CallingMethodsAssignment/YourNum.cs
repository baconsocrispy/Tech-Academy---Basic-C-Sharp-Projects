using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{   
    // Create a class w/3 methods that each take one integer
    // parameter in  and return an integer. Methods should
    // do some math operations.
    internal class YourNum
    {
        // Constructor method. Sets user Num parameter
        // on construction
        public YourNum(int Num1) 
        {
            Num = Num1;
        }

        // Creates get/set methods to access/change
        // user number
        public int Num { get; set; } 

        // Multiplies user number by a chosen multiplier
        public int Multiply(int multiplier)
        {
            return this.Num * multiplier;
        }

        // Adds a chosen number to the user number
        public int Add(int num2)
        {
            return this.Num + num2;
        }

        // Subtracts a chosen number from the user number
        public int Subtract(int num3)
        {
            return this.Num - num3;
        }
    }
}
