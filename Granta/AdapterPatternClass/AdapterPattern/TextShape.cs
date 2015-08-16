using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextLibrary;  // only using this for Point struct

namespace AdapterPattern
{
    public class TextShape: TextView, IShape
    {
        public TextShape(Point _bottomLeft, Point _topRight) : base(_bottomLeft, _topRight)
        { }

        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            int bottom, left, width, height;
            
            GetOrigin(out left, out bottom); // GOF listing is wrong way round
            GetExtent(out width, out height);

            bottomLeft = new Point { X = left, Y = bottom };
            topRight = new Point { X = bottom + height, Y = left + width };
        }

        public Manipulator CreateManipulator()
        {
            return new Manipulator(this);
        }
    }
}
