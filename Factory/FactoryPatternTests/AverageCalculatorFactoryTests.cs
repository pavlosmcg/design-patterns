using FactoryPattern;
using FactoryPattern.Implementations;
using NUnit.Framework;

namespace FactoryPatternTests
{
    [TestFixture]
    public class AverageCalculatorFactoryTests
    {
        [Test]
        public void ShouldCreateMedianCalculator()
        {
            var averageCalculatorFactory = new AverageCalculatorFactory();

            var calculator = averageCalculatorFactory.CreateCalculator(CalculatorType.Median);

            Assert.That(calculator, Is.TypeOf<Median>());
        }

        [Test]
        public void ShouldCreateMeanCalculator()
        {
            var averageCalculatorFactory = new AverageCalculatorFactory();

            var calculator = averageCalculatorFactory.CreateCalculator(CalculatorType.Mean);

            Assert.That(calculator, Is.TypeOf<Mean>());
        }

        [Test]
        public void ShouldCreateModeCalculator()
        {
            var averageCalculatorFactory = new AverageCalculatorFactory();

            var calculator = averageCalculatorFactory.CreateCalculator(CalculatorType.Mode);

            Assert.That(calculator, Is.TypeOf<Mode>());
        }
    }
}