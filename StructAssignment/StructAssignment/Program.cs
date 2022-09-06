using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        // create a struct called Number
        public struct Number
        {
            // give it a decimal property called Amount
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            // create a Number object and assign an amount to it
            Number num = new Number() { Amount = .0009m };

            // print amount to console
            Console.WriteLine(num.Amount);

            Console.ReadLine();
        }
    }
}
