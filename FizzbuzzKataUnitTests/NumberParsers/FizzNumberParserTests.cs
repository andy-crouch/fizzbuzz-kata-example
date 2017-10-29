using FizzbuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzbuzzKataUnitTests.NumberParsers
{
    [TestClass]
    public class FizzNumberParserTests
    {
        [TestMethod]
        public void Divisor_ReturnsThree()
        {
            Assert.AreEqual(3, new FizzNumberParser().Divisor);
        }

        [TestMethod]
        public void Parse_WhenPassedNumberNotDivisibleByThree_ReturnsNumberAsString()
        {
            var numberParser = new FizzNumberParser();

            Assert.AreEqual("10", numberParser.Parse(10));
        }

        [TestMethod]
        public void Parse_WhenPassedNumberDivisibleByThree_ReturnsFizzWord()
        {
            var numberParser = new FizzNumberParser();

            Assert.AreEqual("Fizz", numberParser.Parse(9));
        }
    }
}
