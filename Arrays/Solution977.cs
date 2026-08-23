namespace LeetCode.Arrays
{
    public class Solution977
    {
        public int[] SortedSquares(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int[] sortedSquares = new int[nums.Length];
            int index = nums.Length - 1;

            while(left <= right)
            {
                int leftSquare = nums[left] * nums[left];
                int rightSquare = nums[right] * nums[right];
                if(leftSquare >= rightSquare)
                {
                    sortedSquares[index] = leftSquare;
                    left++;
                }
                else
                {
                    sortedSquares[index] = rightSquare;
                    right--;
                }
                index--;
            }
            
            return sortedSquares;
        }
    }
}
