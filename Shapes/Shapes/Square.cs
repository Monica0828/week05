using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(int width)
        {
            Height = width;
            Width = width; 
        }

        public override int CalculateSurface()
        {
            return Height * Width;
        }
    }
}
