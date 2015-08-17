using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
	public class TextViewWithScroll
    {
        private int _topLine;

		public TextViewWithScroll(int topLine)
        {
            _topLine = topLine;
        }

        public void Draw()
        {
			GUI.DrawScrollBar(_topLine);
			GUI.DrawTextView();
        }
    }
}
