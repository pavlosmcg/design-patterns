using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextLibrary
{
    public struct Point
    {
        public int X, Y;
    }

    public class TextView
    {
        // math coords not computer screen (i.e. origin in bottom left)
        private Point bottomLeft, topRight;

        public bool IsEmpty { get; set; }

        public TextView(Point _bottomLeft, Point _topRight)
        {
            bottomLeft = _bottomLeft;
            topRight = _topRight;
        }

        public void GetOrigin(out int x, out int y)
        {
            x = bottomLeft.X;
            y = bottomLeft.Y;
        }

        public void GetExtent(out int width, out int height)
        {
            width = topRight.X - bottomLeft.X;
            height = topRight.Y - bottomLeft.Y;
        }
    }
}
