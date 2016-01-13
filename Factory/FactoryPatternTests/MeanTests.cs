using FactoryPattern.Implementations;
using NUnit.Framework;

namespace FactoryPatternTests
{
    [TestFixture]
    public class MeanTests
    {
        [Test]
        public void ShouldCalculateCorrectAverageUsingMean()
        {
            int[] collectionOfNumbers = { 13, 18, 13, 14, 13, 16, 14, 21, 13 };
            var expectedAverage = 15;

            var calculator = new Mean();

            var actualAverage = calculator.Average(collectionOfNumbers);

            Assert.That(actualAverage, Is.EqualTo(expectedAverage));
        }

    }
}
