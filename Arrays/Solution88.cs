using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class Solution88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int x = m - 1;
            int y = n - 1;
            int z = nums1.Length - 1;

            while (y >= 0)
            {
                if (x >= 0 && nums1[x] > nums2[y])
                {
                    nums1[z] = nums1[x];
                    x--;
                }
                else
                {
                    nums1[z] = nums2[y];
                    y--;
                }
                z--;
            }
        }
    }
}
