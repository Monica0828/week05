using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            list.Add(new Square(5));
            list.Add(new Rectangle(5, 6));
            list.Add(new Triangle(8, 9));

            foreach (var item in list)
            {
                Console.WriteLine($"Area of the {item.GetType()} is {item.CalculateSurface()}");
            }

            Console.ReadKey();
        }
    }
}
