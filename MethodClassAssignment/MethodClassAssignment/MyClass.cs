using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class MyClass
    {
        // create a class
        public MyClass() { }


        //create a void method that takes two int params
        public void Math(int num1, int num2)
        {
            // have the method do a math operation on the first int
            // and display the second int to screen
            num1 *= 5000;
            Console.WriteLine(num2);
        }
    }
}
