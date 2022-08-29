using System;

namespace VectorShapes
{
    public class FourSides : IFourSides
    {
        private int _xParam;
        private int _yParam;
        private int _width;
        private int _height;

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
        public int Width
        {
            get => _width;
            set => _width = value;
        }
        public virtual int Height
        {
            get => _height;
            set => _height = value;
        }

        public FourSides(int xParam, int yParam, int width, int height)
        {
            Width = width;
            Height = height;
            XParam = xParam;
            YParam = yParam;

            ErrorCheck();
        }

        public FourSides(int xParam, int yParam, int size)
        {
            Width = size;
            Height = size;
            XParam = xParam;
            YParam = yParam;

            ErrorCheck();
        }

        public void ErrorCheck()
        {
            if (Height < 1 || Width < 1)
            {
                throw new ArgumentException("The Height or Width cannot be less than 1.");
            }
        }
    }
}
