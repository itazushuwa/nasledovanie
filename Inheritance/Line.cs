using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Line : Point
    {
        public override string Name()
        {
            return "Отрезок";
        }
        public double X2;
        public double Y2;
        public Line(double x, double y, double x2, double y2) : base(x, y)
        {
            X2 = x2;
            Y2 = y2;
        }
        public override double Size()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(X - X2, 2) + Math.Pow(Y - Y2, 2)));
        }
    }
}