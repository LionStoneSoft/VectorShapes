using System;
using System.Collections.Generic;
using System.Text;

namespace VectorShapes
{
    public class Circular : ICircular
    {
        private int _xParam;
        private int _yParam;
        private int _hDiameter;
        private int _vDiameter;

        public int XParam
        {
            get => _xParam;
            set => _xParam = value;
        }
        public int YParam
        {
            get => _yParam;
            set => _yParam = value;
        }
        public int HDiameter
        {
            get => _hDiameter;
            set => _hDiameter = value;
        }
        public virtual int VDiameter
        {
            get => _vDiameter;
            set => _vDiameter = value;
        }

        public Circular(int xParam, int yParam, int hDiameter, int vDiameter)
        {
            HDiameter = hDiameter;
            VDiameter = vDiameter;
            XParam = xParam;
            YParam = yParam;

            ErrorCheck();
        }

        public Circular(int xParam, int yParam, int size)
        {
            HDiameter = size;
            VDiameter = size;
            XParam = xParam;
            YParam = yParam;

            ErrorCheck();
        }

        public void ErrorCheck()
        {
            if (HDiameter < 1 || VDiameter < 1)
            {
                throw new ArgumentException("The Height or Width cannot be less than 1.");
            }
        }
    }
}
