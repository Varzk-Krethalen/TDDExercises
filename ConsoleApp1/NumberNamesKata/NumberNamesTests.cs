using NUnit.Framework;

namespace NumberNamesKata
{
    [TestFixture]
    public class NumberNamesTests
    {
        private string Generate(long input)
        {
            return NumberNames.Generate(input);
        }
        private string[] Generate(long[] input)
        {
            return NumberNames.Generate(input);
        }

        [Test]
        public void Generate_ShouldReturnANonEmptyString_Always()
        {
            Assert.IsNotEmpty(Generate(0));
        }

        [Test]
        public void Generate_ShouldSucceed_ForASingleDigit()
        {
            Assert.AreEqual("Zero", Generate(0));
        }

        [Test]
        public void Generate_ShouldSucceed_ForADifferentSingleDigit()
        {
            Assert.AreEqual("Seven", Generate(7));
        }

        [Test]
        public void Generate_ShouldReturnAStringArray_FortSingleDigitArrayInput()
        {
            long[] numbers = { 1, 2 };
            string[] names = { "One", "Two" };
            Assert.AreEqual(names, Generate(numbers));
        }

        [Test]
        public void Generate_ShouldReturnAStringArray_ForDifferentSingleDigitArrayInput()
        {
            long[] numbers = { 5, 9, 3, 7, 4, 8, 0, 1, 2, 4, 6 };
            string[] names = {
                "Five", "Nine", "Three", "Seven", "Four", "Eight",
                "Zero", "One", "Two", "Four", "Six"
            };
            Assert.AreEqual(names, Generate(numbers));
        }

        [Test]
        public void Generate_ShouldReturnAStringArray_ForTenToNineteen()
        {
            long[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            string[] names = {
                "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            };
            Assert.AreEqual(names, Generate(numbers));
        }

        [Test]
        public void Generate_ShouldReturnAStringArray_ForTwentyToNinetyNine()
        {
            long[] numbers = { 20, 25, 31, 57, 68, 84, 99 };
            string[] names = {
                "Twenty", "Twenty Five", "Thirty One", "Fifty Seven",
                "Sixty Eight", "Eighty Four", "Ninety Nine"
            };
            Assert.AreEqual(names, Generate(numbers));
        }

        [Test]
        public void Generate_ShouldReturnAStringArray_ForOneHundredToNineHundredNinetyNine()
        {
            long[] numbers = { 100, 205, 310, 570, 678, 824, 999 };
            string[] names = {
                "One Hundred", "Two Hundred and Five", "Three Hundred and Ten",
                "Five Hundred and Seventy", "Six Hundred and Seventy Eight",
                "Eight Hundred and Twenty Four", "Nine Hundred and Ninety Nine"
            };
            Assert.AreEqual(names, Generate(numbers));
        }

        [Test]
        public void Generate_ShouldReturnAStringArray_ForOneThousandToJustUnderOneMillion()
        {
            long[] numbers = { 1000, 2050, 3107, 5470, 6788, 18241, 999999 };
            string[] names = {
                "One Thousand", "Two Thousand and Fifty", "Three Thousand, One Hundred and Seven",
                "Five Thousand, Four Hundred and Seventy", "Six Thousand, Seven Hundred and Eighty Eight",
                "Eighteen Thousand, Two Hundred and Forty One",
                "Nine Hundred and Ninety Nine Thousand, Nine Hundred and Ninety Nine"
            };
            Assert.AreEqual(names, Generate(numbers));
        }

        [Test]
        public void Generate_ShouldReturnAStringArray_ForOneMillionUp()
        {
            long[] numbers = { 1000000, 2050037, 31075385, 547000000, 6788000000, 1824100000000, 999999999999 };
            string[] names = {
                "One Million",
                "Two Million, Fifty Thousand and Thirty Seven",
                "Thirty One Million, Seventy Five Thousand, Three Hundred and Eighty Five",
                "Five Hundred and Forty Seven Million",
                "Six Thousand, Seven Hundred and Eighty Eight Million",
                "One Million, Eight Hundred and Twenty Four Thousand, One Hundred Million",
                "Nine Hundred and Ninety Nine Thousand, Nine Hundred and Ninety Nine Million, Nine Hundred and Ninety Nine Thousand, Nine Hundred and Ninety Nine"
            };
            Assert.AreEqual(names, Generate(numbers));
        }
    }
}
