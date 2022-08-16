using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main()
        {
            // take user input and multiply by 50, print to console
            Console.WriteLine("Pick a number less than 10m");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * 50);

            // adds 25 to user input, prints to console
            Console.WriteLine("Pick another number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num2 + 25);

            // divides user input by 12.5, prints to console
            Console.WriteLine("Pick another number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(num3 / 12.5);

            // tests if user input greater than 50, prints to console
            Console.WriteLine("Pick another number");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine(num4 > 50);

            // divides user input by 7, prints remainder to console
            Console.WriteLine("Pick another number");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine(num5 % 7);

            Console.Read();
        }
    }
}
