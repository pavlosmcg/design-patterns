using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
	public class ScrollDecorator : IVisualComponent
    {
        private int _topLine;
		private readonly IVisualComponent _component;

		public ScrollDecorator(IVisualComponent component, int topLine)
        {
			_component = component;
            _topLine = topLine;
        }

        public void Draw()
        {
			Console.WriteLine("Scroll bar being displayed. First line being displayed is line {0}.", _topLine);
			_component.Draw();
        }
    }
}
