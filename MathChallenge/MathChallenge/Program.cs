using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    internal class Program
    {
        static void Main()
        {
            int num1 = 25;
            int num2 = 25;
            int sumTotal = num1 + num2;

            int num3 = 65;
            int num4 = 32;
            int difference = num3 - num4;

            int num5 = 984375;
            int num6 = 14;
            int product = num5 * num6;

            int num7 = 239487;
            int num8 = 31;
            int quotient = num7 / num8;

            Console.WriteLine(sumTotal);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
         
            string fname = "Carter";
            string lname = "Bacon";
            string name = fname + lname;

            Console.WriteLine(name);


            Console.Read();

        }
    }
}
