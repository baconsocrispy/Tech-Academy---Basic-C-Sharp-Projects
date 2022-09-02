using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    internal class MyClass
    {
        // create a class
        public MyClass() { }

        // create a method that takes 2 int parameters with one being optional
        public int Math(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
