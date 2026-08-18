using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class Solution121
    {
        public int MaxProfit(int[] prices)
        {
            int minimumPrice = prices[0];
            int maximumProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if(prices[i] > minimumPrice)
                {
                    int result = prices[i] - minimumPrice;
                    if (result > maximumProfit)
                    {
                        maximumProfit = result;
                    }
                }
                else
                {
                    minimumPrice = prices[i];
                }
            }

            return maximumProfit;
        }
    }
}
