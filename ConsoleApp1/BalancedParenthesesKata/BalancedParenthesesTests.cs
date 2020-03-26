

using NUnit.Framework;

namespace BalancedParenthesesKata
{
    [TestFixture]
    public class BalancedParenthesesTests
    {
        BalancedParentheses balanceChecker;

        [SetUp]
        public void Setup()
        {
            balanceChecker = new BalancedParentheses();
        }
        
        private bool IsBalanced(string stringToTest)
        {
            return balanceChecker.IsBalanced(stringToTest);
        }

        [Test]
        public void IsBalanced_ShouldReturnTrue_ForAnEmptyString()
        {
            Assert.AreEqual(true, IsBalanced(""));
        }

        [Test]
        public void IsBalanced_ShouldReturnTrue_ForACorrectSetOfMultipleRoundBrackets()
        {
            Assert.AreEqual(true, IsBalanced("((())())"));
        }

        [Test]
        public void IsBalanced_ShouldReturnFalse_ForAWrongOrderRoundBracketPair()
        {
            Assert.AreEqual(false, IsBalanced("(()))(()"));
        }

        [Test]
        public void IsBalanced_ShouldReturnFalse_ForTooManyOpenBrackets()
        {
            Assert.AreEqual(false, IsBalanced("(()))((()"));
        }

        [Test]
        public void IsBalanced_ShouldReturnFalse_ForTooManyClosedBrackets()
        {
            Assert.AreEqual(false, IsBalanced("(()))()"));
        }

        [Test]
        public void IsBalanced_ShouldReturnTrue_ForACorrectSetOfMultipleSquareBrackets()
        {
            Assert.AreEqual(true, IsBalanced("[[][]]"));
        }
        
        [Test]
        public void IsBalanced_ShouldReturnTrue_ForACorrectSetOfMultipleCurlyBraces()
        {
            Assert.AreEqual(true, IsBalanced("{}{}{}"));
        }

        [Test]
        public void IsBalanced_ShouldReturnFalse_ForAWrongOrderSquareBracketPair()
        {
            Assert.AreEqual(false, IsBalanced("{{{}}"));
        }

        [Test]
        public void IsBalanced_ShouldReturnTrue_ForACorrectCombinationOfAllBrackets()
        {
            Assert.AreEqual(true, IsBalanced("[({}){[]}]"));
        }

        [Test]
        public void IsBalanced_ShouldReturnFalse_ForMultipleBracketTypesInTheWrongOrder()
        {
            Assert.AreEqual(false, IsBalanced("[({)}]"));
        }

        [Test]
        public void IsBalanced_ShouldReturnFalse_ForBracketsInTheWrongOrderWithSpacing()
        {
            Assert.AreEqual(false, IsBalanced("[[([]])[]]"));
        }
    }
}
