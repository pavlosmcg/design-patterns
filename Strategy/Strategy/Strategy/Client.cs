using System;
using System.Collections.Generic;

namespace Strategy
{
	public class Client
	{
		public Client ()
		{
			
		}

		public IEnumerable<string> ProcessNames(IEnumerable<string> names) 
		{
			var algorithm = new Algorithms.Formal ();
			return algorithm.Execute (names);
		}
	}
}
	