using System;
using System.Collections.Generic;

namespace Strategy
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// create some names, as if by input or from some database:
			var names = new List<string> { "David", "Leonard", "Laura", "Linda", "Stephen", "Jean" };

			var someClient = new Client (); 
			//TODO: refactor the client and algorithms so that uncommenting the folling line works:
			//var someClient = new Client(new Algorithms.Cool());

			var results = someClient.ProcessNames(names);
			foreach(var result in results) {
				Console.WriteLine (result);
			};
		}
	}
}
