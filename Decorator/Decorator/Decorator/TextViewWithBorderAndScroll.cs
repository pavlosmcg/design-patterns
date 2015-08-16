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
			DrawBorder();
			Console.WriteLine("Scroll bar being displayed. First line being displayed is line {0}.", _topLine);
			new TextView().Draw();
        }

		public void DrawBorder() 
		{
			Console.WriteLine("Border drawn with width {0}.", _width);
		}
    }
}
