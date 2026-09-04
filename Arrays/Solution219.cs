namespace LeetCode.Arrays
{
    public class Solution219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> valueIndex = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(valueIndex.TryGetValue(nums[i], out int storedIndex))
                {
                    int difference = i - storedIndex;
                    if(difference <= k)
                    {
                        return true;
                    }
                }
                valueIndex[nums[i]] = i;
            }
            return false;
        }
    }
}
