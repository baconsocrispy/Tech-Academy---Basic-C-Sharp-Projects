using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class MyClass
    {
        // create class
        public MyClass() { }

        // create a void method that outputs an integer
        public void DivideBy2(int num1, out int num2)
        {
            // divide data passed to it by 2
            num2 = num1 / 2;
        }

        // create a method with output parameters
        public void GetTwoOutputs(int num1, out int num2, out int num3)
        {
            num2 = num1 * 5;
            num3 = num1 * 10;
        }

        // overload a method
        public void GetTwoOutputs(string string1, out string string2, out string string3)
        {
            string2 = string1 + "test1";
            string3 = string1 + "test2";
        }

    }
}
