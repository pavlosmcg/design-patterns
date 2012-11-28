using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextLibrary;  // only using this for Point struct

namespace AdapterPattern
{
    public class TextShape: Shape
    {
        private readonly TextView textView;
        public TextShape(TextView _textView)
        {
            textView = _textView;
        }

        public override void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            int bottom, left, width, height;
            
            textView.GetOrigin(out left, out bottom); // GOF listing is wrong way round
            textView.GetExtent(out width, out height);

            bottomLeft = new Point { X = left, Y = bottom };
            topRight = new Point { X = bottom + height, Y = left + width };
        }

        public override Manipulator CreateManipulator()
        {
            return new Manipulator(this);
        }
    }
}
