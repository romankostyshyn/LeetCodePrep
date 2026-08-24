namespace LeetCode.Arrays
{
    public class Solution283
    {
        public void MoveZeroes(int[] nums)
        {
            int writePointer = 0;

            for(int scanPointer = 0; scanPointer < nums.Length; scanPointer++)
            {
                if(nums[scanPointer] != 0)
                {
                    nums[writePointer] = nums[scanPointer];
                    writePointer++;
                }
            }

            for(int i = writePointer; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
