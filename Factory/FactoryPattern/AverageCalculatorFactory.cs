using FactoryPattern.Implementations;

namespace FactoryPattern
{
    /// <summary>
    /// Responsibility of deciding which implementation to use is encapsulated within the Factory class
    /// </summary>
    public class AverageCalculatorFactory
    {
        public IAverageCalculator CreateCalculator(CalculatorType type)
        {
            //NB: Yes, I have an If statement here, but it is never to be repeated!
            if (type == CalculatorType.Mean)
                return new Mean();

            if (type == CalculatorType.Median)
                return new Median();

            if (type == CalculatorType.Mode)
                return new Mode();

            throw new UnknownCalculatorTypeException(type);
        }
    }
}