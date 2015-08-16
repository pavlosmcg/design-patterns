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
            Window window = new Window();
            TextView textView = new TextView();

            // plain old text view
            //window.SetContents(textView);

            // decorated text view
            window.SetContents(new BorderDecorator(new ScrollDecorator(textView, 54), 5));

            window.DrawContents();
        }
    }
}
