using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a simple program
            Console.WriteLine("What's your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is " + yourName);
            Console.ReadLine();

            Console.WriteLine("What's your favorite number?");
            string faveNumber = Console.ReadLine();
            Console.WriteLine("Your fave num is " + faveNumber);
            Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char randomLetter = '\u2103';

            decimal moneyInBacnk = 100.5m;
            double heightInCm = 211.23498230;
            float secondsLeft = 2.62f;
            short tempOnMars = -341;
            string myName = "Carter";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();
            


        }
    }
}
