using LotsOfPracticeProblems;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AppleStocksTradingTests
    {
        [Test]
        public void AlwaysNegative()
        {
            var trade = new AppleStocksTrading();
            Assert.AreEqual(-1, trade.ProfitByScrolling(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
            Assert.AreEqual(-2, trade.ProfitByScrolling(new[] { 10, 8 }));
            Assert.AreEqual(-2, trade.ProfitByScrolling(new[] { 10, 8, 5 }));
            Assert.AreEqual(-1, trade.ProfitByScrolling(new[] { 10, 5, 4 }));
            Assert.AreEqual(-1, trade.ProfitByScrolling(new[] { 10, 9, 4 }));
            Assert.AreEqual(0, trade.ProfitByScrolling(new[] { 10, 10 }));
            Assert.AreEqual(0, trade.ProfitByScrolling(new[] { 0, 0 }));
        }

        [Test]
        public void AlwaysPositive()
        {
            var trade = new AppleStocksTrading();
            Assert.AreEqual(7, trade.ProfitByScrolling(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }

        [Test]
        public void Messy()
        {
            var trade = new AppleStocksTrading();
            Assert.AreEqual(6, trade.ProfitByScrolling(new[] { 5,3,7,9,4,5,6,6,4,5,7,5,6,7,4,6,2,6,3,1,5}));
        }
    }
}
