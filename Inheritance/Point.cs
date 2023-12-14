using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Point : Figure
    {
        public override string Name()
        {
            return "Точка";
        }
        public double X;
        public double Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override double Size()
        {
            return 0;
        }
    }
}