using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1
{
    public class SquareAdapter : IShape
    {
        private Square _square;

        public SquareAdapter(Square square)
        {
            _square = square;
        }

        public double GetArea()
        {
            double sideLength = _square.GetSideLength();
            return sideLength * sideLength;
        }
    }
}
