using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning05
{
    public class Square : Shape
    {
        private double _side;

        public Square (string color, double side) : base (color)
        {
            _side = side;
        }
        public override double GetArea()
        {
            return _side * _side;
        }
    }
}
