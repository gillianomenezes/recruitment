using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Raet.Recruitment.Refactoring.Shapes
{
    [TestClass()]
    public class ShapeTest
    {
        private List<Shape> _shapes;

        [TestInitialize]
        public void Initialize()
        {
            _shapes = new List<Shape>();
        }

        [TestMethod]
        public void givenEmptyList_whenPrint_thenReturnEmptyMessage()
        {
            Assert.AreEqual("Empty list of shapes!", Shape.Print(_shapes));
        }

        [TestMethod]
        public void givenOneSquare_whenPrint_thenReturnShapePrint()
        {
            _shapes.Add(new Square(2));
            Assert.AreEqual("Squares: 1, Area: 4, Perimeter: 8.", Shape.Print(_shapes));
        }

        [TestMethod]
        public void givenOneShapePerType_whenPrint_thenReturnOrderedShapesPrint()
        {
            //_shapes.Add(new Triangle(3));
            //_shapes.Add(new Square(1));            
            //_shapes.Add(new Circle(2));

            
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Square(1));

            Assert.AreEqual("Squares: 1, Area: 1, Perimeter: 4.\nCircles: 1, Area: 3.14, Perimeter: 6.28.\nTriangles: 1, Area: 3.9, Perimeter: 9.", Shape.Print(_shapes));
        }

        [TestMethod]
        public void givenMultipleShapes_whenPrint_thenReturnOrderedSumShapesPrint()
        {
            _shapes.Add(new Square(1));
            _shapes.Add(new Triangle(8));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Triangle(3));
            _shapes.Add(new Circle(4));
            _shapes.Add(new Circle(2));
            _shapes.Add(new Circle(3));
            _shapes.Add(new Square(3));
            _shapes.Add(new Triangle(1));
            Assert.AreEqual("Circles: 4, Area: 25.92, Perimeter: 34.56.\nTriangles: 3, Area: 32.04, Perimeter: 36.\nSquares: 2, Area: 10, Perimeter: 16.", Shape.Print(_shapes));
        }
    }
}
