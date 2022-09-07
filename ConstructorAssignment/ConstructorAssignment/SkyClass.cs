using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class SkyClass
    {
        // chain two constructors together
        public SkyClass(int clouds) : this(clouds, "BLUE")
        {
        }
        public SkyClass(int clouds, string sky_color)
        {
            Clouds = clouds;
            SkyColor = sky_color;
        }
        public string SkyColor { get; set; }
        public int Clouds { get; set; }
    }
}
