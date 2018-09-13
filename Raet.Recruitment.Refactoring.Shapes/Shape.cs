using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Refactoring.Shapes
{
    public abstract class Shape
    {
        public double Width { get; set; }

        public Shape(double width)
        {
            this.Width = width;
        }

        public static String Print(List<Shape> shapes)
        {
            String returnString = "";
            if (shapes.Count == 0)
                returnString = "Empty list of shapes!";

            var types = shapes.Select(x => x.GetType()).Distinct();
            int shapesOfPreviousTypeAmount = 0;

            foreach(var type in types)
            {
                string shapeName = shapes.Find(s => s.GetType() == type).PrintShapeName();
                string shapeArea = shapes.FindAll(s => s.GetType() == type)
                                            .Sum(x => x.getArea())
                                            .ToString("#.##", CultureInfo.InvariantCulture);

                string shapePerimeter = shapes.FindAll(s => s.GetType() == type)
                                            .Sum(x => x.getPerimeter())
                                            .ToString("#.##", CultureInfo.InvariantCulture);

                int shapeAmount = shapes.FindAll(s => s.GetType() == type).Count;

                string shapeMsg = shapeName + ": " + shapeAmount + ", Area: " + shapeArea + ", Perimeter: " + shapePerimeter + ".";

                if ((shapesOfPreviousTypeAmount > shapeAmount) || shapesOfPreviousTypeAmount == 0)
                    returnString += shapeMsg;
                else
                    returnString = shapeMsg + "\n" + returnString;

                shapesOfPreviousTypeAmount = shapeAmount;
            }
            
            return returnString.Trim();
        }

        public abstract double getWidth();

        public abstract double getArea();

        public abstract double getPerimeter();

        public abstract string PrintShapeName();
    }
}
