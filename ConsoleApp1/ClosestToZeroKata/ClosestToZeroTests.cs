using NUnit.Framework;
using System;

namespace ClosestToZeroKata
{
    [TestFixture]
    public class ClosestToZeroTests
    {
        int[] inputValues;
        

        private int getResult(int[] inputValues)
        {
            return ClosestToZero.Calculate(inputValues);
        }

        [Test]
        public void Calculate_ShouldReturnInput_IfOnlyOneInteger()
        {
            inputValues = new int[] { 1 };
            Assert.AreEqual(1, getResult(inputValues));
        }

        [Test]
        public void Calculate_ShouldReturnDifferentInput_IfOnlyOneInteger()
        {
            inputValues = new int[] { 2 };
            Assert.AreEqual(2, getResult(inputValues));
        }

        [Test]
        public void Calculate_ShouldReturnSmallestValue_FromAnUnorderedSetOfPositiveIntegers()
        {
            inputValues = new int[] { 3, 4, 1, 5, 2 };
            Assert.AreEqual(1, getResult(inputValues));
        }

        [Test]
        public void Calculate_ShouldReturnSmallestValue_FromADifferentUnorderedSetOfPositiveIntegers()
        {
            inputValues = new int[] { 9, 66, 5, 32, 57, 12, 43 };
            Assert.AreEqual(5, getResult(inputValues));
        }

        [Test]
        public void Calculate_ShouldReturnSmallestValue_FromAnUnorderedSetOfNegativeIntegers()
        {
            inputValues = new int[] { -3, -4, -1, -5, -2 };
            Assert.AreEqual(-1, getResult(inputValues));
        }

        [Test]
        public void Calculate_ShouldReturnSmallestValue_FromADifferentUnorderedSetOfNegativeIntegers()
        {
            inputValues = new int[] { -9, -66, -5, -32, -57, -12, -43 };
            Assert.AreEqual(-5, getResult(inputValues));
        }

        [Test]
        public void Calculate_ShouldReturnSmallestValue_FromASetOfMixedIntegers()
        {
            inputValues = new int[] { -103, -57, -32, -5, 3, 15, 46, 89 };
            Assert.AreEqual(3, getResult(inputValues));
        }

        [Test]
        public void Calculate_ShouldReturnPositiveValue_IfTheyAreEqualAbsoluteValue()
        {
            inputValues = new int[] { -5, -3, 3, 5 };
            Assert.AreEqual(3, getResult(inputValues));
        }
    }
}
