using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            Console.WriteLine(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (seen.ContainsKey(diff))
                {
                    Console.WriteLine($"{seen[diff]}, {i}");
                    return [seen[diff], i];
                }

                else if (!seen.ContainsKey(nums[i]))
                {
                    seen.Add(nums[i], i);
                }
            }

            throw new ArgumentException("not found");
        }
    }
}
