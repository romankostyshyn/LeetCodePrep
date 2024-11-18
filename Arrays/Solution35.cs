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
            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return l;
        }
    }
}
