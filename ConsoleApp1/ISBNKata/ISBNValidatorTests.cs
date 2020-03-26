using NUnit.Framework;

namespace ISBNKata
{
    class ISBNValidatorTests
    {
        ISBNValidator isbn;

        [SetUp]
        public void Setup()
        {
            isbn = new ISBNValidator();
        }

        public bool Validate13(string input)
        {
            return isbn.Validate(input, 13);
        }

        public bool Validate10(string input)
        {
            return isbn.Validate(input, 10);
        }

        [Test]
        public void ValidateISBN13_ShouldFail_WithEmptyInput()
        {
            Assert.AreEqual(false, Validate13(""));
        }


        [Test]
        public void ValidateISBN13_ShouldFail_WithInvalidLengthInput()
        {
            Assert.AreEqual(false, Validate13("12345678912345"));
        }

        [Test]
        public void ValidateISBN13_ShouldFail_WithDifferentInvalidLengthInput()
        {
            Assert.AreEqual(false, Validate13("123456789123"));
        }

        [Test]
        public void ValidateISBN13_ShouldFail_WithDifferentInvalidLengthInputUsingHyphens()
        {
            Assert.AreEqual(false, Validate13("1234567891-23"));
        }

        [Test]
        public void ValidateISBN13_ShouldFail_WithInvalidLengthInputUsingSpaces()
        {
            Assert.AreEqual(false, Validate13("12 345678912345"));
        }

        [Test]
        public void ValidateISBN13_ShouldSucceed_WithValidInput()
        {
            Assert.AreEqual(true, Validate13("9780470059029"));
        }

        [Test]
        public void ValidateISBN13_ShouldSucceed_WithValidInputOfCheckDigit0()
        {
            Assert.AreEqual(true, Validate13("9236225687530"));
        }

        [Test]
        public void ValidateISBN13_ShouldSucceed_WithValidInputUsingHyphens()
        {
            Assert.AreEqual(true, Validate13("9-780-470-05-9029"));
        }

        [Test]
        public void ValidateISBN13_ShouldSucceed_WithValidInputUsingSpaces()
        {
            Assert.AreEqual(true, Validate13("978 047 0059 029"));
        }

        [Test]
        public void ValidateISBN13_ShouldNotSucceed_WithInvalidInput()
        {
            Assert.AreEqual(false, Validate13("9780470059023"));
        }

        [Test]
        public void ValidateISBN10_ShouldFail_WithEmptyInput()
        {
            Assert.AreEqual(false, Validate10(""));
        }


        [Test]
        public void ValidateISBN10_ShouldFail_WithInvalidLengthInput()
        {
            Assert.AreEqual(false, Validate10("047195869756"));
        }

        [Test]
        public void ValidateISBN10_ShouldFail_WithDifferentInvalidLengthInput()
        {
            Assert.AreEqual(false, Validate10("04719586"));
        }

        [Test]
        public void ValidateISBN10_ShouldFail_WithDifferentInvalidLengthInputUsingHyphens()
        {
            Assert.AreEqual(false, Validate10("047-100-958697"));
        }

        [Test]
        public void ValidateISBN10_ShouldFail_WithInvalidLengthInputUsingSpaces()
        {
            Assert.AreEqual(false, Validate10("0 4710 0958 697"));
        }

        [Test]
        public void ValidateISBN10_ShouldSucceed_WithValidInput()
        {
            Assert.AreEqual(true, Validate10("0471958697"));
        }

        [Test]
        public void ValidateISBN10_ShouldSucceed_WithValidInputOfCheckDigit0()
        {
            Assert.AreEqual(true, Validate10("0321146530"));
        }

        [Test]
        public void ValidateISBN10_ShouldSucceed_WithValidInputUsingHyphens()
        {
            Assert.AreEqual(true, Validate10("047-195-8697"));
        }

        [Test]
        public void ValidateISBN10_ShouldSucceed_WithValidInputUsingSpaces()
        {
            Assert.AreEqual(true, Validate10("0 4719 58 697"));
        }

        [Test]
        public void ValidateISBN10_ShouldNotSucceed_WithInvalidInput()
        {
            Assert.AreEqual(false, Validate10("0472958697"));
        }
    }
}
