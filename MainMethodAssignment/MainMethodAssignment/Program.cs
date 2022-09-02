using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            MathClass new_class = new MathClass(25);

            // call the method and print result to screen
            Console.WriteLine(new_class.Multiply(25));

            // instantiate the class
            MathClass another_class = new MathClass(62);

            // call the second method and print to screen
            Console.WriteLine(another_class.Multiply(44.7623m));

            // instantiate the class
            MathClass yet_another_class = new MathClass(19);

            // call the third method and print to screen
            Console.WriteLine(yet_another_class.Multiply("-6"));

            Console.ReadLine();
        }
    }
}
