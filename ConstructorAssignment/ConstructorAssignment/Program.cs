using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a const variable
            const string sky_color = "GREEN";

            //// create a variable using var
            var sky_string = new SkyClass(14, sky_color);
            var sky_string2 = new SkyClass(4);

            Console.WriteLine(sky_string.Clouds);
            Console.WriteLine(sky_string.SkyColor);

            Console.WriteLine(sky_string2.Clouds);
            Console.WriteLine(sky_string2.SkyColor);

            Console.Read();

        }
    }
}
