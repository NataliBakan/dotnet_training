using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_5_6
{
    class Shape
    {
        public virtual double GetArea()
        {
            return 2;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; } 
        public double Height { get; set; }

        public Rectangle(double width, double height) 
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return (Width * Height) / 2;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
