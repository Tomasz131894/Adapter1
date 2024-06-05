using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1
{
    public class Square
    {
        public double SideLength { get; private set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double GetSideLength()
        {
            return SideLength;
        }
    }

}
