using System.Linq;

namespace FactoryPattern.Implementations
{
    public class Mode : IAverageCalculator
    {
        public int Average(int[] listOfValues)
        {
            int? greatestFrequency = null;
            var median = 0;

            foreach (var distinctItem in listOfValues.Distinct())
            {
                var countOfItem = listOfValues.Count(x => x == distinctItem);

                if (!greatestFrequency.HasValue)
                {
                    greatestFrequency = countOfItem;
                    median = distinctItem;
                }
                else if (countOfItem > greatestFrequency.Value)
                {
                    greatestFrequency = countOfItem;
                    median = distinctItem;
                }
            }

            return median;
        }
    }
}