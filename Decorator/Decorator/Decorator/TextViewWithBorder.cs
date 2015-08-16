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
			DrawBorder();
			new TextView().Draw();
        }

		public void DrawBorder() 
		{
			Console.WriteLine("Border drawn with width {0}.", _width);
		}
    }
}
