﻿using System;


namespace Exceptions_Video_Exercise
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Pick a number:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int number3 = number1 / number2;
                Console.WriteLine(number1 + " divided by " + number2 + " equals " + number3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
