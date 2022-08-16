using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main()
        {
            // First line must be "Welcome to Package Express. Please follow the instructions below."
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // User must be prompted for the package weight
            Console.WriteLine("Please enter your package weight.");
            float weight = float.Parse(Console.ReadLine());

            // Display error if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");    
            }
            else
            {
                // User must be prompted for package width/height/length
                Console.WriteLine("What is the package width?");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                float length = float.Parse(Console.ReadLine());

                // Display error if dimensions total more than 50
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Calculate and display quote
                    float quote = (width * height * length * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is $" + quote);
                }
            }

            Console.Read();
        }
    }
}
