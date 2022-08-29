using System.Collections.Generic;
using System.Text;

namespace VectorShapes
{
    public interface IFourSides
    {
        int XParam
        {
            get;
            set;
        }

        int YParam
        {
            get;
            set;
        }
        int Width
        {
            get;
            set;
        }

        int Height
        {
            get;
            set;
        }

        //string PrintOutput();
    }
}
