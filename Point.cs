using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1_OOP
{
    internal struct Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public double DistaceBetween(Point other)
        {
            return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(x - other.x, 2));
        }
    }
}
