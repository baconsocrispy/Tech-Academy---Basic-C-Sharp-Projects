using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            // arrays must have a declared length and can be instantiated the three ways below
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            numArray2[5] = 650;

            Console.WriteLine(numArray[3]);
            Console.WriteLine(numArray1[4]);
            Console.WriteLine(numArray2[5]);

            // lists can be composed of any data type and don't have a set length
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            Console.WriteLine(intList[0]);

            Console.ReadLine();
        }
    }
}
