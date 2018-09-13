using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    class Triangle : Shape
    {
        public Triangle(double width) : base(width)
        {
        }

        public override double getArea()
        {
            return (Math.Sqrt(3) / 4) * base.Width * base.Width;
        }

        public override double getPerimeter()
        {
            return 3 * base.Width;
        }

        public override double getWidth()
        {
            return base.Width;
        }

        public override string PrintShapeName()
        {
            return "Triangles";
        }
    }
}
