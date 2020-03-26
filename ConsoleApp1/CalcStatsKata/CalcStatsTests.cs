using NUnit.Framework;

namespace CalcStatsKata
{
    [TestFixture]
    public class CalcStatsTests
    {
        public string Calculate(int[] input)
        {
            CalcStats statMaker = new CalcStats();
            return statMaker.CalculateStatistics(input);
        }

        [Test]
        public void CalculateStatistics_ShouldReturnNumberOfItems()
        {
            int[] testItems = { 1, 2, 3, 4, 5 };
            StringAssert.Contains("Number of Elements: 5", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnNumberOfItems_ForADifferentSet()
        {
            int[] testItems = { 1, 3, 5 };
            StringAssert.Contains("Number of Elements: 3", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnAverageItem()
        {
            int[] testItems = { 1, 2, 3, 4, 5 };
            StringAssert.Contains("Average Value: 3", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnAverageItem_ForADifferentSet()
        {
            int[] testItems = { 1, 11, 19, 103, -14 };
            StringAssert.Contains("Average Value: 24", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnMaximumItem()
        {
            int[] testItems = { 1, 2, 3, 4, 5 };
            StringAssert.Contains("Maximum Value: 5", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnMaximumItem_ForADifferentSet()
        {
            int[] testItems = { -1, -11, -19, -103, -14 };
            StringAssert.Contains("Maximum Value: -1", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnMinimumItem()
        {
            int[] testItems = { 1, 2, 3, 4, 5 };
            StringAssert.Contains("Minimum Value: 1", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnMinimumItem_ForADifferentSet()
        {
            int[] testItems = { 1, 11, 19, 103, -14 };
            StringAssert.Contains("Minimum Value: -14", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnSumOfItems()
        {
            int[] testItems = { 1, 2, 3, 4, 5 };
            StringAssert.Contains("Sum of Elements: 15", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnSumOfItems_ForADifferentSet()
        {
            int[] testItems = { 1, 11, 19, 103, -14 };
            StringAssert.Contains("Sum of Elements: 120", Calculate(testItems));
        }

        [Test]
        public void CalculateStatistics_ShouldReturnFullOutput()
        {
            int[] testItems = { 1, 11, 19, 103, -14 };
            Assert.AreEqual("Number of Elements: 5, Average Value: 24, Maximum Value: 103, Minimum Value: -14, Sum of Elements: 120", Calculate(testItems));
        }
    }
}
