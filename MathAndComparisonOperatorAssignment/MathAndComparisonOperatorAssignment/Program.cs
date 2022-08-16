using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    internal class Program
    {
        static void Main()
        {
            // Must start by printing "Anonymous Income Comparison Program"
            Console.WriteLine("Anonymous Income Comparison Program");

            // Must print "Person 1" to screen and get hourly rate/hours worked
            Console.WriteLine("Person 1: What's your hourly rate?");
            decimal hourlyRate1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Person 1: How many hours did you work this week?");
            int hoursWorked1 = int.Parse(Console.ReadLine());

            // Must print "Person 2" to screen and get hourly rate/hours worked
            Console.WriteLine("Person 2: What's your hourly rate?");
            decimal hourlyRate2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Person 2: How many hours did you work this week?");
            int hoursWorked2 = int.Parse(Console.ReadLine());

            // Must print "Annual salary of Person 1:" and display exact salary
            decimal person1Salary = hourlyRate1 * hoursWorked1 * 52;
            Console.WriteLine("Annual salary of Person 1: \n$" + person1Salary);

            // Must print "Annual salary of Person 2:" and display exact salary
            decimal person2Salary = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine("Annual salary of Person 2: \n$" + person2Salary);

            // Must print "Does Person 1 make more than Person 2" and display true/false
            bool whoIsRicher = person1Salary > person2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2:\n" + whoIsRicher);


            Console.Read();
        }
    }
}
