using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
	public class TextViewWithBorderAndScroll
    {
        private int _width;
		private int _topLine;

		public TextViewWithBorderAndScroll(int borderWidth, int topLine)
        {
            _width = borderWidth;
			_topLine = topLine;
        }

        public void Draw()
        {
			GUI.DrawBorder(_width);
			GUI.DrawScrollBar(_topLine);
			GUI.DrawTextView();
        }
    }
}
