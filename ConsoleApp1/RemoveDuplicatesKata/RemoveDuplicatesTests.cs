using NUnit.Framework;
using System.Collections.Generic;

namespace RemoveDuplicatesKata
{
    [TestFixture]
    public class RemoveDuplicatesTests
    {
        public T[] Simplify<T>(T[] list)
        {
            return RemoveDuplicates.Simplify(list);
        }

        [Test]
        public void SimplifyInt_ShouldReturnInput_WithNoDuplicates()
        {
            int[] list = { 1, 2, 3 };
            Assert.AreEqual(Simplify(list), list);
        }

        [Test]
        public void SimplifyString_ShouldReturnInput_WithNoDuplicates()
        {
            string[] list = { "1", "2", "3" };
            Assert.AreEqual(Simplify(list), list);
        }

        [Test]
        public void SimplifyInt_ShouldRemoveDuplicates_WhenInOrder()
        {
            int[] list = { 1, 2, 2, 3, 3, 3 };
            int[] expected = { 1, 2, 3 };
            Assert.AreEqual(Simplify(list), expected);
        }

        [Test]
        public void SimplifyString_ShouldRemoveDuplicates_WhenInOrder()
        {
            string[] list = { "1", "2", "2", "3", "3", "3" };
            string[] expected = { "1", "2", "3" };
            Assert.AreEqual(Simplify(list), expected);
        }

        [Test]
        public void SimplifyInt_ShouldRemoveDuplicates_WhenUnordered()
        {
            int[] list = { 3, 7, 1, 5, 1, 7, 7, 5 };
            int[] expected = { 3, 7, 1, 5 };
            Assert.AreEqual(Simplify(list), expected);
        }

        [Test]
        public void SimplifyString_ShouldRemoveDuplicates_WhenUnordered()
        {
            string[] list = { "3", "7", "1", "5", "1", "7", "7", "5" };
            string[] expected = { "3", "7", "1", "5" };
            Assert.AreEqual(Simplify(list), expected);
        }
    }
}