using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class Solution136
    {
        public int SingleNumber(int[] nums)
        {
            int answer = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                answer ^= nums[i];
            }

            return answer;
        }
    }
}
