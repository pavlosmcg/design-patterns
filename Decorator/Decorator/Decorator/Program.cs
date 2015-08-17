using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
			// plain old text view
			var textView = new TextView();

            // decorated text view
			// TODO uncomment this line when you have refactored TextViewWithBorder and TextViewWithScroll
			//var decoratedTextView = new BorderDecorator(new ScrollDecorator(textView, 54), 5);

			// change this line to render your decorated text view
			RenderView (textView);
        }

		static void RenderView(IVisualComponent component)
		{
			component.Draw();
		}
    }
}
