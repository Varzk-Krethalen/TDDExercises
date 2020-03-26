using NUnit.Framework;

namespace WordWrapKata
{
    class WordWrapperTests
    {
        WordWrapper wrapper;

        [SetUp]
        public void Setup()
        {
            wrapper = new WordWrapper();
        }

        public string Wrap(string inputLine, int columnWidth)
        {
            return wrapper.Wrap(inputLine, columnWidth);
        }

        [Test]
        public void Wrap_ShouldReturnEmptyString_WithWidthZero()
        {
            Assert.AreEqual("", Wrap("test", 0));
        }

        [Test]
        public void Wrap_ShouldReturnInputString_WithWidthGreaterThanInputLength()
        {
            Assert.AreEqual("test", Wrap("test", 567));
        }

        [Test]
        public void Wrap_ShouldReturnInputString_WithWidthEqualToInputLength()
        {
            Assert.AreEqual("test", Wrap("test", 4));
        }

        [Test]
        public void Wrap_ShouldReturnCorrectString_WithWidthOfHalf()
        {
            Assert.AreEqual("te\nst", Wrap("test", 2));
        }

        [Test]
        public void Wrap_ShouldReturnDifferentCorrectString_WithWidthOfHalf()
        {
            Assert.AreEqual("TestS\ntring", Wrap("TestString", 5));
        }

        [Test]
        public void Wrap_ShouldReturnCorrectString_WithWidthOfAQuarter()
        {
            Assert.AreEqual("Fo\nur\nFo\nur", Wrap("FourFour", 2));
        }

        [Test]
        public void Wrap_ShouldReturnCorrectString_WithWidthThatIsNotADivisor()
        {
            Assert.AreEqual("Fo\nur\nFo\nur\nSi\nx", Wrap("FourFourSix", 2));
        }

        [Test]
        public void Wrap_ShouldReturnDifferentCorrectString_WithWidthThatIsNotADivisor()
        {
            Assert.AreEqual("Correct\nHorseBa\ntterySt\naples", Wrap("CorrectHorseBatteryStaples", 7));
        }

        [Test]
        public void Wrap_ShouldReturnCorrectString_WithDistinctWords()
        {
            Assert.AreEqual("Correct\nHorse\nBattery\nStaples", Wrap("Correct Horse Battery Staples", 7));
        }

        [Test]
        public void Wrap_ShouldReturnCorrectString_WithVariableLengthWords()
        {
            Assert.AreEqual("Seventee\nn\nVariable\nName\nLengths", Wrap("Seventeen Variable Name Lengths", 8));
        }
    }
}
