using System;

namespace Decorator
{
	public static class GUI
	{
		// this class is pretending to be some code that draws things in a GUI - nothing to see here. move along.

		public static void DrawTextView() 
		{
			Console.WriteLine("Text view drawn.");
		}

		public static void DrawBorder(int width)
		{
			Console.WriteLine("Border drawn with width {0}.", width);
		}

		public static void DrawScrollBar(int topLine)
		{
			Console.WriteLine("Scroll bar being displayed. First line being displayed is line {0}.", topLine);
		}
	}
}

