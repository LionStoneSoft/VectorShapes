using System;
using System.Collections.Generic;
using System.Text;

namespace VectorShapes
{
    class Ellipse : Circular, ICircular
    {
        public Ellipse(int xParam, int yParam, int HDiameter, int VDiameter) : base(xParam, yParam, HDiameter, VDiameter)
        {
            if (VDiameter == HDiameter)
            {
                throw new ArgumentException("To be an Ellipse the Vertical Diameter cannot be the same as the Horizontal Diameter.");
            }

        }

        public string PrintOut()
        {
            return $"Ellipse ({XParam},{YParam}) diameterH = {HDiameter} diameterV = {VDiameter}";
        }
    }
}
