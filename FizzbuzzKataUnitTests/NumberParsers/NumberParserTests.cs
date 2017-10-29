using FizzbuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzbuzzKataUnitTests.NumberParsers
{
    [TestClass]
    public class NumberParserTests
    {
        [TestMethod]
        public void Divisor_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, new NumberParser().Divisor);
        }

        [TestMethod]
        public void Parse_ReturnsNumberAsString()
        {
            var numberParser = new NumberParser();

            Assert.AreEqual("10", numberParser.Parse(10));
        }
    }
}
