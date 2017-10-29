using FizzbuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzbuzzKataUnitTests.NumberParsers
{
    [TestClass]
    public class BuzzNumberParserTests
    {
        [TestMethod]
        public void Divisor_ReturnsFive()
        {
            Assert.AreEqual(5, new BuzzNumberParser().Divisor);
        }

        [TestMethod]
        public void Parse_WhenPassedNumberNotDivisibleByFive_ReturnsNumberAsString()
        {
            var numberParser = new BuzzNumberParser();

            Assert.AreEqual("11", numberParser.Parse(11));
        }

        [TestMethod]
        public void Parse_WhenPassedNumberDivisibleByFive_ReturnsBuzzWord()
        {
            var numberParser = new BuzzNumberParser();

            Assert.AreEqual("Buzz", numberParser.Parse(10));
        }
    }
}
