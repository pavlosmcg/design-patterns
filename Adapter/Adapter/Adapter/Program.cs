using System;
using System.Collections.Generic;

namespace Adapter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var fowl = new List<IDuck> () {
				new MallardDuck(),
				new MallardDuck(),
				// TODO when you have written a new TurkeyAdapter class, the line below should work
				//new TurkeyAdapter(new Turkey())
			};

			foreach (var bird in fowl) {
				bird.Quack ();
				bird.Fly ();
			}
		}
	}
}
