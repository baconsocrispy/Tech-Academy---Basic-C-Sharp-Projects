using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class MathClass
    {
        // create a class
        public MathClass(int num1)
        {
            Num = num1;
        }
        public int Num { get; set; }

        // create a method that takes in an integer,
        // does some math and returns an integer
        public int Multiply(int num2)
        {
            return this.Num * num2;
        }

        // create a different method with the same name that takes a decimal
        // Create a different math operation and return answer as integer.
        public int Multiply(decimal num3)
        {
            int n = Convert.ToInt32(num3);
            return this.Num * 2 * n;
        }

        // add a third method with the same name that takes a string,
        // converts it to an integer if possible. Does a different math operation.
        public int Multiply(string num4)
        {
            int n = int.Parse(num4);
            return this.Num * -4000 * n;
        }
    }
}
