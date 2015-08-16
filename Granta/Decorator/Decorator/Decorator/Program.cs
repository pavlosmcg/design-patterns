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
            // window.SetContents(textView);

            // decorated text view
            window.SetContents(new BorderDecorator(new ScrollDecorator(textView, 54), 5));

            window.DrawContents();
        }

        public static void DrawBorder(int borderWidth)
        {
            Console.WriteLine("Border drawn with width {0}.", borderWidth.ToString());
        }

        public static void DisplayScrollBar(int topLine)
        {
            Console.WriteLine("Scroll bar being displayed. First line being displayed is line {0}.", topLine.ToString());
        }
    }
}
