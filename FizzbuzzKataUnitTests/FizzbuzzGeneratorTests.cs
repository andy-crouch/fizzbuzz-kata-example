using FizzbuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FizzbuzzKataUnitTests
{
    [TestClass]
    public class FizzbuzzGeneratorTests
    {
        FizzbuzzGenerator _fizzbuzzGenerator;

        [TestInitialize]
        public void Setup()
        {
            _fizzbuzzGenerator = new FizzbuzzGenerator();
        }

        [TestMethod]
        public void GenerateResults_Returns_AStringList()
        {
            var resultSet = _fizzbuzzGenerator.GenerateResults(0, 0);
            Assert.IsInstanceOfType(resultSet, typeof(List<string>));
        }

        [TestMethod]
        public void GenerateResults_WhenPassedResultSetRange_ReturnsAStringListContainingExpectedNumberOfResults()
        {
            var resultSet = _fizzbuzzGenerator.GenerateResults(1, 100);
            Assert.AreEqual(100, resultSet.Count);
        }

        [TestMethod]
        public void GenerateResults_WhenPassedResultSetRangeOfNine_ReturnsAStringListContainingNineResults()
        {
            var resultSet = _fizzbuzzGenerator.GenerateResults(1, 9);
            Assert.AreEqual(9, resultSet.Count);
        }

        [TestMethod]
        public void GenerateResults_WhenValidRange_ReturnsNumbersDivisibleByThreeAsFizz()
        {
            var resultSet = _fizzbuzzGenerator.GenerateResults(1, 3);
            Assert.AreEqual("Fizz", resultSet.Last());
        }

        [TestMethod]
        public void GenerateResults_WhenValidRange_ReturnsNumbersDivisibleByFiveAsBuzz()
        {
            var resultSet = _fizzbuzzGenerator.GenerateResults(1, 5);
            Assert.AreEqual("Buzz", resultSet.Last());
        }

        [TestMethod]
        public void GenerateResults_WhenValidRange_ReturnsNumbersDivisibleByThreeAndFiveAsFizzbuzz()
        {
            var resultSet = _fizzbuzzGenerator.GenerateResults(1, 15);
            Assert.AreEqual("Fizzbuzz", resultSet.Last());
        }
    }
}
