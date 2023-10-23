using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Circle : Shape,IDrawable
    {
        public double Radius {  get; set; }
        public const double Pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            var area = Pi * Radius * Radius;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2 * Pi * Radius;
            return perimeter;
        }

        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
