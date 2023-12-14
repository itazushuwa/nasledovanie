using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Square : Line
    {
        public override string Name()
        {
            return "Квадрат";
        }
        public Square(double x, double y, double x2, double y2) : base(x, y, x2, y2)
        {

        }
        public override double Size()
        {
            return Math.Pow(base.Size(), 2);
        }
        //public override double Size()
        //{
        //    return base.Size() * 4;
        //}
    }
}