using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextLibrary;  // only using this for Point struct

namespace AdapterPattern
{
    public interface IShape
    {
        void BoundingBox(out Point bottomLeft, out Point topRight);

        Manipulator CreateManipulator();
    }
}
