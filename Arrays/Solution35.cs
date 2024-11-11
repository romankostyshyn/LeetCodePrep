using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class Solution35
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Contains(target))
            {
                return Array.IndexOf(nums, target);
            }

            return 0;
        }
    }
}
