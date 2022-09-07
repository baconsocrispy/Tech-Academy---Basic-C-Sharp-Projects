using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prints the current date and time to the console
            Console.WriteLine(DateTime.Now);

            // asks for a number
            Console.WriteLine("Please enter a number:");
            int num = int.Parse(Console.ReadLine());

            // prints to console time it will be in x hours
            DateTime time_now = DateTime.Now;

            DateTime time_in_x_hours = time_now.AddHours(num);
            Console.WriteLine(time_in_x_hours);

            Console.ReadLine();


        }
    }
}
