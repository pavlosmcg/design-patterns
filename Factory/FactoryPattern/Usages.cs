using System.Linq;

namespace FactoryPattern
{
    public class Usages
    {
        public int CalculateAverage_TheBadWay(int[] listOfValues, CalculatorType type)
        {
            var average = 0;

            if (type == CalculatorType.Mean)
            {
                #region Implementation of Mean
                var total = 0;

                foreach (var item in listOfValues)
                {
                    total = total + item;
                }

                average = total / listOfValues.Count();
                #endregion
            }

            if (type == CalculatorType.Median)
            {
                #region Implemenation for Median
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

                average = median;
                #endregion 
            }

            if (type == CalculatorType.Mode)
            {
                #region implementation of mode
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

                average = median;
                #endregion
            }

            /*
 The code above does not do one thing, it actually has 4 responsibilities:
    - calculates the average for mean, mode & median (that's 3 responsibilities!)
    - and determines which calculation to use
             
 This means that the decision of which calculation to use and the calculation themselves are tightly coupled:
 I risk breaking all 4 responsibilities whenever I change any code in this method!!!
 
Imagine how many unit tests I will need to write for this one method in order to achieve 100% coverage....
             
 Unfortunately this is a common occurrence & core services is littered with similar examples of
             
 * If (ProductCode == "PC") //do x
 * If (ProductCode == "LC") //do Y
 * If (ProductCode == "BI") //do Z
             
 The problem gets worse when you start to add more and more variations:
             
 * If (ProductCode == "PC") //do x
 * If (ProductCode == "LC") //do Y
 * If (ProductCode == "BI") //do Z
 * If (ProductCode == "HO") //do A
 * If (ProductCode == "LI") //do B
 * If (ProductCode == "PT") //do C
             
 But it grows exponentially when the number of places in the code that need to make the decision increases: 
      for example the way you 
             * (1) Save 
             * (2) Load 
             * (3) Edit 
             * (4) Delete 
             
       a risk, depending on whether it is a Car, Van, Bike, etc 
 

     If Statements and Switch Statements are evil - try to avoid them :)
 */


            return average;
        }

        public int CalculateAverage_TheGoodWay(int[] listOfValues, CalculatorType type)
        {
//          Responsibility of deciding which implementation to use is encapsulated within the Factory class
            var creatorOfAverageCalulators = new AverageCalculatorFactory();
            
            var averageCalculator = creatorOfAverageCalulators.CreateCalculator(type);

            //responsibility for performing the calculation is pushed down to where it belongs; with each of the concrete implementations of IAverageCalculator
            
            return averageCalculator.Average(listOfValues);

            /*
             Here we have separated Responsibilities of deciding which implementation to use, and the actual implementations of those calculations.
             Now, if we want to change how we calculate Mode (the implementation is a bit poor and could use a refactor!):
             - we have no fear of breaking the other calculations
             - we have no fear of breaking the logic that determines which algorithm to use
             - Each implementation is independently testable, as is the factory.
             Also
             - Its easy to add or remove implementations without the breaking the others
             */
        }
    }
}