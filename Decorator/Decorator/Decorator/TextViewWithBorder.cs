using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
	public class TextViewWithBorder
    {
        private int _width;

		public TextViewWithBorder(int borderWidth)
        {
            _width = borderWidth;
        }

        public void Draw()
        {
			GUI.DrawBorder (_width);
			GUI.DrawTextView ();
        }
    }
}
