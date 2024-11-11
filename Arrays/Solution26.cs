using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class Solution26
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> uniqueNums = new List<int>();
            int duplicates = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!uniqueNums.Contains(nums[i]))
                {
                    uniqueNums.Add(nums[i]);
                }
                else
                {
                    duplicates++;
                }
            }

            nums = uniqueNums.ToArray();
            int[] newArray = new int[nums.Length + duplicates];
            Array.Copy(nums, newArray, nums.Length);
            nums = newArray;
            Console.WriteLine($"{uniqueNums.Count} {nums.Length}");
            return uniqueNums.Count;
        }
    }
}
