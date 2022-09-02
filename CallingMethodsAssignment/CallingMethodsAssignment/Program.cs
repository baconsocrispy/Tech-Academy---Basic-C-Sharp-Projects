using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number:");
            int number = int.Parse(Console.ReadLine());
            YourNum num1 = new YourNum(number);

            int result1 = num1.Multiply(32);
            int result2 = num1.Add(345879);
            int result3 = num1.Subtract(23179487);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
