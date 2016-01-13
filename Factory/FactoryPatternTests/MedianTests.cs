using FactoryPattern.Implementations;
using NUnit.Framework;

namespace FactoryPatternTests
{
    [TestFixture]
    public class MedianTests
    {
        [Test]
        public void ShouldCalculateCorrectAverageUsingMedian()
        {
            int[] collectionOfNumbers = { 13, 18, 13, 14, 13, 16, 14, 21, 13 };
            var expectedAverage = 14;

            var calculator = new Median();

            var actualAverage = calculator.Average(collectionOfNumbers);

            Assert.That(actualAverage, Is.EqualTo(expectedAverage));
        }
    }
}
