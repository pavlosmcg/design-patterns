using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.Algorithms
{
	public class Cool
	{
		public IEnumerable<string> Execute(IEnumerable<string> inputList)
		{
			return inputList.Select (item => string.Format("Hey yo {0},", item));
		}
	}
}

