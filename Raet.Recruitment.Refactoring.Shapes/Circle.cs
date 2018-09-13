using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    class Circle : Shape
    {
        public Circle(double width) : base(width)
        {
        }

        public override double getArea()
        {
            return Math.PI * (base.Width / 2) * (base.Width / 2);
        }

        public override double getPerimeter()
        {
            return Math.PI * base.Width;
        }

        public override double getWidth()
        {
            return base.Width;
        }

        public override string PrintShapeName()
        {
            return "Circles";
        }
    }
}
