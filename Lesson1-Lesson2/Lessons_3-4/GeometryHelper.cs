using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_3_4
{

    class GeometryHelper
    {
        public double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double RectangleArea(double a, double b)
        {
            return a * b;
        }
    }
}
