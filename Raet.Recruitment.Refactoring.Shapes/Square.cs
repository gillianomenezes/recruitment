using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    class Square : Shape
    {
        public Square(double width) : base(width)
        {
        }

        public override double getArea()
        {
            return base.Width * base.Width;
        }

        public override double getPerimeter()
        {
            return 4 * base.Width;
        }

        public override double getWidth()
        {
            return base.Width;
        }

        public override string PrintShapeName()
        {
            return "Squares";
        }
    }
}
