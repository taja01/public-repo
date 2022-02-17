using System;
using System.Collections.Generic;

namespace CodeWarsTests.Tasks.LeetCode
{
    public class Problems
    {
        //1. Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                var s = target - current;
                if (dict.TryGetValue(s, out var index))
                {
                    return new[] { index, i };
                }

                dict[current] = i;
            }

            return null;
        }

        //121. Best Time to Buy and Sell Stock
        public static int MaxProfix(int[] prices)
        {
            var profit = 0;
            var minValue = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                {
                    minValue = prices[i];
                }
                else
                {
                    profit = Math.Max(profit, (prices[i] - minValue));
                }
            }

            return profit;
        }
    }
}
