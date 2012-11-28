using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextLibrary;  // only using this for Point struct

namespace AdapterPattern
{
    public class Manipulator
    {
        Shape shapeToDisplay;

        public Manipulator(Shape _shape)
        {
            shapeToDisplay = _shape;
        }

        public void Display()
        {
            Point bottomLeft, topRight;
            shapeToDisplay.BoundingBox(out bottomLeft, out topRight);
            Console.WriteLine("Bottom left: X={0}, y={1}", bottomLeft.X.ToString(),bottomLeft.Y.ToString());
            Console.WriteLine("Top right: X={0}, y={1}", topRight.X.ToString(), topRight.Y.ToString());
        }
    }
}
