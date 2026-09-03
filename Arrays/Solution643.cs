namespace LeetCode.Arrays
{
    public class Solution643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int currentSum = 0;

            for(int i = 0; i < k; i++)
            {
                currentSum += nums[i];
            }

            int maxSum = currentSum;

            for (int i = 1; i < nums.Length - k + 1; i++)
            {
                int leavingValue = i - 1;
                int enteringValue = k + leavingValue;
                currentSum = currentSum - nums[leavingValue] + nums[enteringValue];
                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            return (double)maxSum / k;

        }
    }
}
