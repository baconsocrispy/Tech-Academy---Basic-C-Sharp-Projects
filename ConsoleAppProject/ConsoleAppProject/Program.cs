// PART 1:
// Create a console app that does the following:
// 1. A one-dimensional array of strings
// 2. Asks user to input some text
// 3. Iterates through each string in the array,
//    adds the user's text to the end of each string.
//    (Does not output to console)
// 4. Creates a second loop that prints off each string one at a time
// 5. Save and execute your code
// PART 2:
// 1. Create an infinite loop
// 2. Fix the infinite loop and add comments how it was fixed
// PART 3:
// 1. Create a loop where comparison operator is <
// 2. Add another loop where the comparison operator is <=
// PART 4:
// 1. Create a list of unique strings
// 2. Ask user to input text to search for in the list
// 3. Create a loop that iterates through the list and displays
//    the index of the list item containing matching text
// 4. Add code that manages when user enters text not in the list
// 5. Add code that stops the loop once a match is found


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Program
    {
        static void Main()
        {
            // PARTS 1, 2, 3
            // Create a one-dimensional array of strings
            string[] words = { "liberty", "grand", "cunning", "honor", "raw", "sensitivity", "expertise", "magnetic", "carrot", "buffet" };

            // asks user to input some text
            Console.WriteLine("Enter some text of your choice, please:");
            string user_text = Console.ReadLine();

            // iterate through each string and add user text to each word
            // created an infinte loop by not incrementing i. fixed it by incrementing i.
            // loop uses a < operator to determine whether to continue
            for ( int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + user_text;
            }

            // create a second loop that prints off each string
            foreach (string word in words )
            {
                Console.WriteLine(word);
            }

            // create a loop using <= operator
            List<string> ten_things = new List<string>();
            while (ten_things.Count <= 10)
            {
                ten_things.Add("thing");
            }
            foreach (string item in ten_things)
            {
                Console.WriteLine(item);
            }

            // PART 4
            // create a list of unique strings
            List<string> uniques = new List<string>() { "judge", "amber", "north", "mayor", "alarm" };

            // prompt user for substring
            Console.WriteLine("Enter a substring to search for:");
            string substring = Console.ReadLine();

            // iterate through list and display index of matching result
            for (int i = 0; i < uniques.Count; i++)
            {
                if (uniques[i].Contains(substring)) 
                {
                    Console.WriteLine("Substring found at position: " + i);
                    // exits when a match is found
                    break;
                }
                // manages when substring not found
                else if (i == uniques.Count - 1)
                {
                    Console.WriteLine("Substring not found...");
                }
            }


            // PART 5
            // create a list containing identical strings
            List<string> identicals = new List<string>() { "judge", "judge", "amber", "amber", "alarm" };

            // prompt user for substring
            Console.WriteLine("Enter a substring to search for:");
            string substring1 = Console.ReadLine();
            bool found = false;

            // iterate through list and display indices of matching results
            for (int i = 0; i < identicals.Count; i++)
            {
                if (identicals[i].Contains(substring1))
                {
                    Console.WriteLine("Substring found at position: " + i);
                    found = true;
                }
            }
            // manages when substring not found
            if (!found)
            {
                Console.WriteLine("Substring not found...");
            }

            // PART 6
            // create a list of strings that has at least two identical strings
            List<string> repeats = new List<string>() { "Tom", "Jim", "Jim", "Sarah", "Jim", "Harold", "Tina", "Tom" };
            List<string> uniques1= new List<string>();

            // create a foreach loop that tests whether name is unique or a duplicate
            foreach (string name in repeats)
            {
                if (uniques1.Contains(name))
                {
                    Console.WriteLine(name + " - this person is a duplicate");
                }
                else
                {
                    uniques1.Add(name);
                    Console.WriteLine(name + " - this person is unique");
                }
            }

            Console.ReadLine();
        }
    }
}
