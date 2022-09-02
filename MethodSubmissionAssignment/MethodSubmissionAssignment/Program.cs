using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            MyClass class_object = new MyClass();

            // prompt user for 2 numbers
            Console.WriteLine("Choose a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose a number....or don't:");
            string num2 = Console.ReadLine();
            
            // if a second number is chosen, run  method with both
            if (int.TryParse(num2, out int value))
            {
                int num3 = value;
                Console.WriteLine(class_object.Math(num1, num3));
            }
            else
            {
                // if no second number, run method with one number
                Console.WriteLine(class_object.Math(num1));
            }
            
            Console.ReadLine();
        }
    }
}
