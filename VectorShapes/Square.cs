using System;
using System.Collections.Generic;
using System.Text;

namespace VectorShapes
{
    class Square : FourSides, IFourSides
    {
        public override int Height { get => base.Height; set => base.Height = Width; }

        public Square(int xParam, int yParam, int size) : base(xParam, yParam, size)
        {
            if (Height != Width)
            {
                throw new ArgumentException("To be a Square the height must be the same as the width.");
            }
        }

        public string PrintOut()
        {
            return $"Square ({XParam},{YParam}) size = {Width}";
        }
    }
}
