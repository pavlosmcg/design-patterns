using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
	public class BorderDecorator : IVisualComponent
    {
        private int _width;
		private readonly IVisualComponent _component;

		public BorderDecorator(IVisualComponent component, int borderWidth)
        {
			_component = component;
            _width = borderWidth;
        }

        public void Draw()
        {
			DrawBorder();
			_component.Draw();
        }

		public void DrawBorder() 
		{
			Console.WriteLine("Border drawn with width {0}.", _width);
		}
    }
}
