using System;

namespace LotsOfPracticeProblems
{
    public class AppleStocksTrading
    {
        public int BruteForceProfit(int[] priceHistory)
        {
            if (priceHistory.Length < 2)
                throw new Exception("blah");

            var max = int.MinValue;
            for (var i = 0; i < priceHistory.Length - 1; i++)
            {
                for (var j = i + 1; j < priceHistory.Length; j++)
                {
                    var difference = priceHistory[j] - priceHistory[i];
                    if (difference > max)
                        max = difference;
                }
            }
            return max;
        }

        public int ProfitByScrolling(int[] priceHistory)
        {
            if (priceHistory.Length < 2)
                throw new Exception("blah");

            var minPrice = priceHistory[0];
            var maxProfit = int.MinValue;

            for (var i = 1; i < priceHistory.Length; i++)
            {
                maxProfit = Math.Max(maxProfit, priceHistory[i] - minPrice);
                minPrice = Math.Min(minPrice, priceHistory[i]);
            }

            return maxProfit;
        }
    }
}