namespace LeetCode.Arrays
{
    public class Solution242
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            int[] counts = new int[26];
            foreach(char character in s)
            {
                int index = character - 'a';
                counts[index]++;
            }
            foreach(char character in t)
            {
                int index = character - 'a';
                counts[index]--;
                if(counts[index] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
