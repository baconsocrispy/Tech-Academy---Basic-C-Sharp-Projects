using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismAssignment
{
    internal class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // implement the Quit() method in any way you choose
        public void Quit()
        {
            Console.WriteLine("I quit, gosh darn it!");
            Console.ReadLine();
        }
    }
}
