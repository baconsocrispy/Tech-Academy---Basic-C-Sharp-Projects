using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            MyClass test_object = new MyClass();

            // prompt user for a number
            Console.WriteLine("Enter a number:");
            int user_num = int.Parse(Console.ReadLine());

            // call the method on the number & display it
            int new_num;   
            test_object.DivideBy2(user_num, out new_num);
            Console.WriteLine(new_num);

            int out1;
            int out2;
            string out3;
            string out4;
            test_object.GetTwoOutputs(-13, out out1, out out2);
            test_object.GetTwoOutputs("Banana", out out3, out out4);

            Console.WriteLine(out1);
            Console.WriteLine(out2);
            Console.WriteLine(out3);
            Console.WriteLine(out4);

            Console.WriteLine(StaticClass.MultiplyBy57(57));

            Console.ReadLine();
        }
    }
}
