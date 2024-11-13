using LeetCode.Arrays;

public class Program
{
    public static void Main(string[] args)
    {
        Solution1 solution1 = new Solution1();
        Solution26 solution26 = new Solution26();
        Solution35 solution35 = new Solution35();
        Solution27 solution27 = new Solution27();
        Solution66 solution66 = new Solution66();

        //solution1.TwoSum([1, 2, 3], 3);
        //Console.WriteLine($"{solution26.RemoveDuplicates([1, 1, 2])}");
        //Console.WriteLine($"{solution35.SearchInsert([1, 3, 4, 5, 6, 7, 8], 2)}");
        //Console.WriteLine($"{solution27.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2)}");
        solution66.PlusOne([8, 9, 9, 9]);
    }
}