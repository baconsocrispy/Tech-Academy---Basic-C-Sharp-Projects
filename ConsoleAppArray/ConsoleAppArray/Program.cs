using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main()
        {
            // create a one-dimensional Array of strings. Ask user to select an index of the array and display string
            string[] talking_heads = { "David Byrne", "Tina Weymouth", "Chris Frantz", "Jerry Harrison" };
            Console.WriteLine("Choose your favorite Talking Head\n0 = DB\n1 = TW\n2 = CF\n3 = JH"); 
            bool valid_choice = false;
            while (!valid_choice)
            {
                int choice = int.Parse(Console.ReadLine());
                if (0 <= choice && choice <= 3)
                {
                    Console.WriteLine(talking_heads[choice] + " is an excellent choice!");
                    valid_choice = true;
                }
                else
                {
                    // display a message if index doesn't exist
                    Console.WriteLine("Not even close, pal, try again...");
                }
            }
            

            // create a one-dimensional array of integers. Ask user to select index and display integer
            int[] root_canal = { 1200, 1500, 1800, 2000 };
            Console.WriteLine("Guess the average cost of a root canal:\n0 = $1200\n1 = $1500\n2 = $1800\n3 = $2000");
            int guess = int.Parse(Console.ReadLine());
            if (guess == 2)
            {
                Console.WriteLine("$" + root_canal[guess] + " is spot on!");
            }
            else if (!(0 <= guess && guess <= 3))
            {
                // display a message if index doesn't exist
                Console.WriteLine("Not even close, pal...");
            }
            else
            {
                Console.WriteLine("$" + root_canal[guess] + " is waaaay off!");
            }

            // create a list of strings. ask user for index and display content at index
            List<string> radiohead = new List<string> { "Thom", "Jonny", "Phil", "Ed", "Colin" };
            Console.WriteLine("Choose your favorite Radiohead guy\n0 = T\n1 = J\n2 = P\n3 = E\n4 = C");
            bool valid_choice1 = false;
            while (!valid_choice1)
            {
                int choice1 = int.Parse(Console.ReadLine());
                if (0 <= choice1 && choice1 <= 4)
                {
                    Console.WriteLine(radiohead[choice1] + " is an excellent choice!");
                    valid_choice1 = true;
                }
                else
                {
                    // display a message if index doesn't exist
                    Console.WriteLine("Not even close, pal, try again...");
                }
            }

            Console.Read();
        }
    }
}
