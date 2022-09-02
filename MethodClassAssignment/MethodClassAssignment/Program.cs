using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            MyClass test_object = new MyClass();

            // call the class method, passing in 2 numbers
            test_object.Math(32, 52);

            // call the class method, specifying the params by name
            test_object.Math(num1: -43, num2: -56);

            Console.ReadLine();
        }
    }
}
