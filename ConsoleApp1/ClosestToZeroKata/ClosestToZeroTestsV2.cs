using NUnit.Framework;

namespace ClosestToZeroKata
{
    [TestFixture]
    public class ClosestToZeroTestsV2
    {
        int[] inputValues;
        
        private int Calculate()
        {
            return ClosestToZeroV2.Calculate(inputValues);
        }

        [Test]
        public void Calculate_ShouldReturnLowestValue_OfPositives()
        {
            inputValues = new int[] { 2, 7, 1, 23 };
            Assert.AreEqual(1, Calculate());
        }

        [Test]
        public void Calculate_ShouldReturnHighestValue_OfNegatives()
        {
            inputValues = new int[] { -12, -7, -10, -23 };
            Assert.AreEqual(-7, Calculate());
        }

        [Test]
        public void Calculate_ShouldReturnClosestToZero_OfNegativesAndPositives()
        {
            inputValues = new int[] { -12, -7, 10, 23 };
            Assert.AreEqual(-7, Calculate());
        }

        [Test]
        public void Calculate_ShouldReturnClosestToZero_OfDifferentNegativesAndPositives()
        {
            inputValues = new int[] { -72, -61, 161, 42 };
            Assert.AreEqual(42, Calculate());
        }

        [Test]
        public void Calculate_ShouldReturnpostive_IfNegativeAndPositiveEqualDistanceFromZero()
        {
            inputValues = new int[] { -3, 3 };
            Assert.AreEqual(3, Calculate());
        }
    }
}
