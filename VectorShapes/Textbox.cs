using System;
using System.Collections.Generic;
using System.Text;

namespace VectorShapes
{
    public class Textbox : FourSides, IFourSides
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => _text = value;
        }

        public Textbox(int xParam, int yParam, int Width, int Height, string text) : base(xParam, yParam, Width, Height)
        {
            Text = text;
            if (string.IsNullOrWhiteSpace(Text))
            {
                throw new ArgumentException("The Textbox text cannot be empty.");
            }
        }

        

        public string PrintOut()
        {
            return $"Textbox ({XParam},{YParam}) width = {Width} height = {Height} Text = {Text}";
        }
    }
}
