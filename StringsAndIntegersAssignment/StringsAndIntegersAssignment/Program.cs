using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    internal class Program
    {
        static void Main()
        {
            // create a list of integers
            List<int> integers = new List<int>() { 23, 54, -65, 0, 77, 2, 95, 41 };

            // add try/catch block to manage exceptions
            try
            {
                // ask the user for a number to divide each number by
                Console.WriteLine("Gimme a number to divide the other numbers by...");
                int divisor = int.Parse(Console.ReadLine());

                // write a loop that takes each integer, divides it by the user number and
                // displays the result to the screen
                foreach (int i in integers)
                {
                    Console.WriteLine(i / divisor);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
                return;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Can only accept integers");
                return;
            }
            finally
            {
                // add a message to indicate try/catch ran successfully
                Console.WriteLine("Successfully ran try/catch block");
                Console.ReadLine();
            }
        }
    }
}
