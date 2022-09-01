using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationVideo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }

            string[] names = { "Jesse", "Erik", "David", "Beth" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                {
                    Console.WriteLine("We found " + names[i]);
                }
            }

            List<int> testScores1 = new List<int>();
            testScores1.Add(98);
            testScores1.Add(99);
            testScores1.Add(81);
            testScores1.Add(72);
            testScores1.Add(70);

            foreach (int score in testScores1)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }

            List<string> names1 = new List<string>() { "Jesse", "Erik", "David", "Beth" };

            foreach (string name in names1)
            {
                Console.WriteLine(name);
            }

            List<int> testScores2 = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores2)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);

            Console.ReadLine();
        }
    }
}
