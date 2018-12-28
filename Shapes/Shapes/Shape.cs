using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        protected int Height;

        protected int Width;

        public abstract int CalculateSurface();
    }
}
