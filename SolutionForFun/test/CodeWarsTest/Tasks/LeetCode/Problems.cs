using System.Collections.Generic;

namespace CodeWarsTests.Tasks.LeetCode
{
    public class Problems
    {
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
    }
}
