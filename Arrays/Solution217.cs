namespace LeetCode.Arrays
{
    public class Solution217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seenValues = new HashSet<int>();
            
            for(int i = 0; i < nums.Length; i++)
            {
                if (!seenValues.Add(nums[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
