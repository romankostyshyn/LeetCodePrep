using LeetCode.Arrays;

public class Program
{
    public static void Main(string[] args)
    {
        Solution26 solution26 = new Solution26();
        Solution35 solution35 = new Solution35();

        //solution26.RemoveDuplicates([1, 1, 2]);
        Console.WriteLine($"{solution35.SearchInsert([1, 2, 3, 4, 5], 3)}");
    }
}