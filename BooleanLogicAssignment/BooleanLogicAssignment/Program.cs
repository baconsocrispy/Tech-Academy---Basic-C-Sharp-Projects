using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main()
        {
            // Must ask age, DUI history, speeding history
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI (true or false)?");
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tix do you have?");
            int tickets = int.Parse(Console.ReadLine());

            // Must check if over 15yo, no DUIs, no more than 3 tickets
            bool qualified = (age > 15) && (dui == false) && (tickets <= 3);

            // print result to screen
            Console.WriteLine("Qualified?\n" + qualified);

            Console.Read();
        }
    }
}
