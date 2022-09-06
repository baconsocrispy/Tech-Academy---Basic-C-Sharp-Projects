using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    internal class Program
    {
        // create an enum for days of the week
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            // wrap code in a try/catch block 
            try
            {
                // prompt the user for today's week day
                Console.WriteLine("Enter the current day of the week:");

                // assign the value to a variable of enum type
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine("Today is: " + day);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
           
            Console.ReadLine();
        }
    }
}
