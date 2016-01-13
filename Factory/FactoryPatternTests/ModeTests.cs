using FactoryPattern.Implementations;
using NUnit.Framework;

namespace FactoryPatternTests
{
    [TestFixture]
    public class ModeTests
    {
        [Test]
        public void ShouldCalculateAverageUsingMean()
        {
            int[] collectionOfNumbers = { 13, 18, 13, 14, 13, 16, 14, 21, 13 };
            var expectedAverage = 13;

            var calculator = new Mode();

            var actualAverage = calculator.Average(collectionOfNumbers);

            Assert.That(actualAverage, Is.EqualTo(expectedAverage));
        }
    }
}