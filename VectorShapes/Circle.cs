using System;
using System.Collections.Generic;
using System.Text;

namespace VectorShapes
{
    public class Circle : Circular, ICircular
    {
        public override int VDiameter { get => base.VDiameter; set => base.VDiameter = HDiameter; }

        public Circle(int xParam, int yParam, int size) : base(xParam, yParam, size)
        {
            if (VDiameter != HDiameter)
            {
                throw new ArgumentException("To be a Circle the Vertical Diameter must be the same as the Horizontal Diameter.");
            }

        }

        public string PrintOut()
        {
            return $"Circle ({XParam},{YParam}) size = {VDiameter}";
        }
    }
}
