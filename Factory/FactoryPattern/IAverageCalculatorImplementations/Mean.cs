using System;
using System.Linq;

namespace FactoryPattern.Implementations
{
    public class Mean : IAverageCalculator
    {
        public int Average(int[] listOfValues)
        {
            var total = 0;

            foreach (var item in listOfValues)
            {
                total = total + item;
            }

            return total/listOfValues.Count();
        }
    }
}
