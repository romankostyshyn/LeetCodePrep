namespace LeetCode.Arrays
{
    public class Solution27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int replace = 0;

            for (int i = 0; i < nums.Length; i++)
            {
               if (nums[i] != val)
                {
                    nums[replace] = nums[i];
                    replace++;
                }
            }

            return replace;
        }
    }
}
