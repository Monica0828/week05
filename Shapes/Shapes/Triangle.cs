using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(int widht, int height)
        {
            Width = widht;
            Height = height;
        }

        public override int CalculateSurface()
        {
            return Height * Width / 2;
        }
    }
}
