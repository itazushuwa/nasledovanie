using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Figure
    {
        public virtual string Name()
        {
            return "Фигура";
        }
        public virtual double Size()
        {
            return default;
        }
    }
}