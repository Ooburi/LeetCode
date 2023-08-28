using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //121. Best Time to Buy and Sell Stock

    //    You are given an array prices where prices[i] is the price of a given stock on the ith day.

    //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future
    //to sell that stock.

    //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    internal class _121_BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0;
            int profit = 0;
            int min = prices[0];

            for(int i = 0; i < prices.Length; i++)
            {
                if(min>prices[i]) min = prices[i];
                if (prices[i] - min > profit) profit = prices[i] - min;
            }
            return profit;
        }
    }
}
