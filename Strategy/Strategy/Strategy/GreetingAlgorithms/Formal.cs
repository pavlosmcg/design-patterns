using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.Algorithms
{
	public class Formal
	{
		public IEnumerable<string> Execute(IEnumerable<string> inputList)
		{
			return inputList.Select (item => string.Format("Dear {0},", item));
		}
	}
}

