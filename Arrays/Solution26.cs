﻿using System;
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
            int replace = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[replace] = nums[i];
                    replace++;
                }
            }

            return replace;
        }
    }
}
