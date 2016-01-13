using System;
using System.Linq;

namespace FactoryPattern.Implementations
{
    public class Median : IAverageCalculator
    {
        public int Average(int[] listOfValues)
        {
            Array.Sort(listOfValues);

            var totalItems = listOfValues.Count();

            if (totalItems%2 != 0)
                totalItems = totalItems + 1;

            var indexOfMiddleItem = totalItems/2;

            return listOfValues[indexOfMiddleItem];
        }
    }
}