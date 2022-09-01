using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main()
        {
            // concatenate 3 strings
            string first = "What ";
            string second = "time ";
            string third = "is it???";
            string together = first + second + third;
            Console.WriteLine(together);

            // convert a string to uppercase
            Console.WriteLine(together.ToUpper());

            // create a Stringbuilder and build a paragraph of text, one sentence at a time
            string sentence1 = "Johnny was three years old when his back started to ache, as if an old man. ";
            string sentence2 = "He went to the doctor, who declared that Johnny was not three, but in fact 103. ";
            string sentence3 = "Johnny had forgotten how old he was. ";
            string sentence4 = "His death 3 days later was welcomed by all who knew him. ";
            string sentence5 = "It's true that Johnny was horrible. ";

            StringBuilder sb = new StringBuilder();
            sb.Append(sentence1);
            sb.Append(sentence2);
            sb.Append(sentence3);
            sb.Append(sentence4);
            sb.Append(sentence5);

            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
