using NUnit.Framework;

namespace LCDDigitsKata
{
    [TestFixture]
    public class LCDDigitsTests
    {
        LCDDigits digitDisplay;
        string zero = 
            " _ \n" +
            "| |\n" +
            "|_|";
        string twelve = 
            "       _ \n" +
            "  |    _|\n" +
            "  |   |_ ";
        string fivethreefour = 
            " _     _       \n" +
            "|_     _|   |_|\n" +
            " _|    _|     |";
        string sixseveneightninenineeightsevensix = 
            " _     _     _     _     _     _     _     _ \n" +
            "|_      |   |_|   |_|   |_|   |_|     |   |_ \n" +
            "|_|     |   |_|     |     |   |_|     |   |_|";

        [SetUp]
        public void SetUp()
        {
            digitDisplay = new LCDDigits();
        }

        string GetDigits(long input)
        {
            return digitDisplay.GetDigits(input);
        }


        [Test]
        public void GetDigits_ShouldReturnCorrectString_ForOneDigit()
        {
            Assert.AreEqual(zero, GetDigits(0));
        }

        [Test]
        public void GetDigits_ShouldReturnEmptyString_ForNegativeNumber()
        {
            Assert.AreEqual("", GetDigits(-3));
        }

        [Test]
        public void GetDigits_ShouldReturnCorrectString_ForTwoDigits()
        {
            Assert.AreEqual(twelve, GetDigits(12));
        }

        [Test]
        public void GetDigits_ShouldReturnCorrectString_ForThreeDigits()
        {
            Assert.AreEqual(fivethreefour, GetDigits(534));
        }

        [Test]
        public void GetDigits_ShouldReturnCorrectString_ForDuplicateDigits()
        {
            Assert.AreEqual(sixseveneightninenineeightsevensix, GetDigits(67899876));
        }
    }
}
