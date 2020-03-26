using NUnit.Framework;

namespace NumberChainsKata
{
    [TestFixture]
    public class NumberChainsTests
    {
        NumberChains chains;

        private int ChainLength(string chain)
        {
            return chain.Split('\n').Length - 2;
        }

        private string Chain(int number)
        {
            return chains.GetNumberChain(number);
        }

        [SetUp]
        public void Setup()
        {
            chains = new NumberChains();
        }

        [Test]
        public void AChainOutputShouldAlwaysContainTheOriginalNumber([Values(0, 1241, 6723412, 2674)] int x)
        {
            StringAssert.Contains($"Original number was {x}", Chain(x));
        }
        [Test]
        public void ASingleChainShouldHaveLengthTwo([Values(1,2,3,4,5,6,7,8,9)] int x)
        {
            Assert.AreEqual(2, ChainLength(Chain(x)));
        }
    }
}