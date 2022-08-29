using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VectorShapes;

namespace ShapeTests
{
    [TestClass]
    public class ShapeTests
    {
        //Rectangle
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestRectangleHeightBelowOne()
        {
            Rectangle rectangle = new Rectangle(10, 10, 30, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestRectangleWidthBelowOne()
        {
            Rectangle rectangle = new Rectangle(10, 10, 0, 40);
        }
        [TestMethod]
        public void TestRectangleY()
        {
            Rectangle rectangle = new Rectangle(10, 10, 30, 40);
            Assert.IsNotNull(rectangle.YParam, "Rectangle Y Parameter is null");
        }

        [TestMethod]
        public void TestRectangleX()
        {
            Rectangle rectangle = new Rectangle(10, 10, 30, 40);
            Assert.IsNotNull(rectangle.XParam, "Rectangle X Parameter is null");
        }
        [TestMethod]
        public void TestRectangleSize()
        {
            Rectangle rectangle = new Rectangle(10, 10, 30, 40);
            Assert.IsNotNull(rectangle.Width, "Rectangle width parameter is null");
        }
        [TestMethod]
        public void TestRectangleOutput()
        {
            int x = 15;
            int y = 30;
            int width = 30;
            int height = 40;
            string output = $"Rectangle ({x},{y}) width = {width} height = {height}";
            Rectangle rectangle = new Rectangle(x, y, width, height);
            Assert.AreEqual(output, rectangle.PrintOut());
        }

        //Square
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestSquareSizeBelowOne()
        {
            Square square = new Square(15, 30, 0);
        }
        [TestMethod]
        public void TestSquareY()
        {
            Square square = new Square(15, 30, 35);
            Assert.IsNotNull(square.YParam, "Square Y Parameter is null");
        }

        [TestMethod]
        public void TestSquareX()
        {
            Square square = new Square(15, 30, 35);
            Assert.IsNotNull(square.XParam, "Square X Parameter is null");
        }
        [TestMethod]
        public void TestSquareSize()
        {
            Square square = new Square(15, 30, 35);
            Assert.IsNotNull(square.Width, "Square width parameter is null");
        }
        [TestMethod]
        public void TestSquareOutput()
        {
            int x = 15;
            int y = 30;
            int size = 35;
            string output = $"Square ({x},{y}) size = {size}";
            Square square = new Square(x, y, size);
            Assert.AreEqual(output, square.PrintOut());
        }

        //Circle
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestCircleSizeBelowOne()
        {
            Circle circle = new Circle(15, 30, 0);
        }
        [TestMethod]
        public void TestCircleY()
        {
            Circle circle = new Circle(15, 30, 35);
            Assert.IsNotNull(circle.YParam, "Circle Y Parameter is null");
        }

        [TestMethod]
        public void TestCircleX()
        {
            Circle circle = new Circle(15, 30, 35);
            Assert.IsNotNull(circle.XParam, "Circle X Parameter is null");
        }
        [TestMethod]
        public void TestCircleSize()
        {
            Circle circle = new Circle(15, 30, 35);
            Assert.IsNotNull(circle.HDiameter, "Circle width parameter is null");
        }
        [TestMethod]
        public void TestCircleOutput()
        {
            int x = 15;
            int y = 30;
            int size = 35;
            string output = $"Circle ({x},{y}) size = {size}";
            Circle circle = new Circle(x, y, size);
            Assert.AreEqual(output, circle.PrintOut());
        }

        //Ellipse
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestEllipseHeightBelowOne()
        {
            Ellipse ellipse = new Ellipse(100, 150, 300, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestEllipseWidthBelowOne()
        {
            Ellipse ellipse = new Ellipse(100, 150, 0, 200);
        }
        [TestMethod]
        public void TestEllipseY()
        {
            Ellipse ellipse = new Ellipse(100, 150, 300, 200);
            Assert.IsNotNull(ellipse.YParam, "Ellipse Y Parameter is null");
        }

        [TestMethod]
        public void TestEllipseX()
        {
            Ellipse ellipse = new Ellipse(100, 150, 300, 200);
            Assert.IsNotNull(ellipse.XParam, "Ellipse X Parameter is null");
        }
        [TestMethod]
        public void TestEllipseSize()
        {
            Ellipse ellipse = new Ellipse(100, 150, 300, 200);
            Assert.IsNotNull(ellipse.HDiameter, "Ellipse width parameter is null");
        }
        [TestMethod]
        public void TestEllipseOutput()
        {
            int x = 15;
            int y = 30;
            int width = 30;
            int height = 40;
            string output = $"Ellipse ({x},{y}) diameterH = {width} diameterV = {height}";
            Ellipse ellipse = new Ellipse(x, y, width, height);
            Assert.AreEqual(output, ellipse.PrintOut());
        }


        //Textbox
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestTextboxHeightBelowOne()
        {
            Textbox textbox = new Textbox(10, 10, 30, 0, "sample text");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Height or Width cannot be less than 1.")]
        public void TestTextboxWidthBelowOne()
        {
            Textbox textbox = new Textbox(5, 5, 0, 100, "sample text");
        }
        [TestMethod]
        public void TestTextboxY()
        {
            Textbox textbox = new Textbox(5, 5, 200, 100, "sample text");
            Assert.IsNotNull(textbox.YParam, "Textbox Y Parameter is null");
        }

        [TestMethod]
        public void TestTextboxX()
        {
            Textbox textbox = new Textbox(5, 5, 200, 100, "sample text");
            Assert.IsNotNull(textbox.XParam, "Textbox X Parameter is null");
        }
        [TestMethod]
        public void TestTextboxSize()
        {
            Textbox textbox = new Textbox(5, 5, 200, 100, "sample text");
            Assert.IsNotNull(textbox.Width, "Textbox width parameter is null");
        }
        [TestMethod]
        public void TestTextboxOutput()
        {
            int x = 5;
            int y = 5;
            int width = 200;
            int height = 100;
            string text = "sample text";
            string output = $"Textbox ({x},{y}) width = {width} height = {height} Text = {text}";
            Textbox textbox = new Textbox(x, y, width, height, text);
            Assert.AreEqual(output, textbox.PrintOut());
        }
    }
}
