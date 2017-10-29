using FizzbuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzbuzzKataUnitTests.NumberParsers
{
    [TestClass]
    public class FizzbuzzNumberParserTests
    {

        [TestMethod]
        public void Divisor_ReturnsFifteen()
        {
            Assert.AreEqual(15, new FizzbuzzNumberParser().Divisor);
        }

        [TestMethod]
        public void Parse_WhenPassedNumberNotDivisibleByFive_ReturnsNumberAsString()
        {
            var numberParser = new FizzbuzzNumberParser();

            Assert.AreEqual("23", numberParser.Parse(23));
        }

        [TestMethod]
        public void Parse_WhenPassedNumberDivisibleByFive_ReturnsBuzzWord()
        {
            var numberParser = new FizzbuzzNumberParser();

            Assert.AreEqual("Fizzbuzz", numberParser.Parse(45));
        }
    }
}
