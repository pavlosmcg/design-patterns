using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.Algorithms
{
	public class Informal
	{
		public IEnumerable<string> Execute(IEnumerable<string> inputList)
		{
			return inputList.Select(item => string.Format("Hi {0},", item));
		}
	}
}

