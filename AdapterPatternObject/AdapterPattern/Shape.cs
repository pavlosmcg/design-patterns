using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextLibrary;  // only using this for Point struct

namespace AdapterPattern
{
    public abstract class Shape
    {
        public abstract void BoundingBox(out Point bottomLeft, out Point topRight);

        public abstract Manipulator CreateManipulator();
    }
}
