namespace LeetCode.Arrays
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> valueToIndex = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if(valueToIndex.TryGetValue(difference, out int previousIndex))
                {
                    return [previousIndex, i];
                }
                valueToIndex[nums[i]] = i;
            }
            throw new InvalidOperationException("No valid pair");
        }
    }
}
