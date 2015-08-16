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
			Console.WriteLine("Scroll bar being displayed. First line being displayed is line {0}.", _topLine);
			new TextView().Draw();
        }
    }
}
