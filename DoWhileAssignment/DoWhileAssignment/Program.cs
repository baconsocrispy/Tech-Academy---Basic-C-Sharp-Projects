using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAssignment
{
    internal class Program
    {
        static void Main()
        {

            // do a boolean comparison using a while statement
            bool correct_color = false;
            while (!correct_color)    
            {
                Console.WriteLine("Choose a color from the list: red, white, blue, green, yellow");
                string color = Console.ReadLine();
                if (color == "red")
                {
                    Console.WriteLine("That's the correct color!");
                    correct_color = true;
                }
                else
                {
                    Console.WriteLine("Incorrect color! Try Again!");
                }
            }

            // do a boolean comparison using a do while statement
            Console.WriteLine("Enter your favorite number");
            int fave_num = int.Parse(Console.ReadLine());
            int i = 0;
            bool is_equal = false;
            do
            {
                Console.WriteLine(i);
                if (i == fave_num)
                {
                    is_equal = true;
                }
                i++;
            } while (!is_equal);
            Console.WriteLine("I'm good at counting...");
            Console.Read();
        }
    }
}
