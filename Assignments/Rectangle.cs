using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle : Shape,IDrawable
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public Double Length {  get; set; }
        public Double Width{ get; set; }
        public override double CalculateArea()
        {
            var area = Length * Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
           var perimeter =2* (Length * Width);
            return perimeter;
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
