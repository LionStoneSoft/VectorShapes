using System;
using System.Collections.Generic;
using System.Text;

namespace VectorShapes
{
    class Rectangle : FourSides, IFourSides
    {

        public Rectangle(int xParam, int yParam, int Width, int Height) :base(xParam, yParam, Width, Height)
        {
            if (Height == Width)
            {
                throw new ArgumentException("To be a Rectangle the height must not be the same as the width.");
            }
        }
        public string PrintOut()
        {
            return $"Rectangle ({XParam},{YParam}) width = {Width} height = {Height}";
        }
    }
}
