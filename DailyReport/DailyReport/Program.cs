using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main()
        {
            // introduction
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            // prompts student for name and saves response as string var
            Console.WriteLine("What's your name?");
            string studentName = Console.ReadLine();

            // prompts student for course and saves response as string var
            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();

            // prompts student for page number and saves response as int var
            // by parsing string 
            Console.WriteLine("What page number are you on?");
            int pageNumber = int.Parse(Console.ReadLine());

            // prompts student for help and casts response as boolean var
            Console.WriteLine("Do you need  help with anything? Please answer true or false.");
            string needHelp = Console.ReadLine();
            bool needHelpBool = Convert.ToBoolean(needHelp);

            // prompts student for experiences and saves response as string var
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string experiences = Console.ReadLine();

            // prompts student for feedback and saves response as string var
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string feedback = Console.ReadLine();

            // prompts student for study hours and saves response as int var
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = int.Parse(Console.ReadLine());

            // prints thank you message
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");


        }
    }
}
