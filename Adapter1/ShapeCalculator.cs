using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1
{
    public class ShapeCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
