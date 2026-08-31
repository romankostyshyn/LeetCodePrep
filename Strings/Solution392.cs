namespace LeetCode.Strings
{
    public class Solution392
    {
        public bool IsSubsequence(string s, string t)
        {
            int indexS = 0;
            int indexT = 0;

            while (indexS < s.Length && indexT < t.Length)
            {
                if (s[indexS] == t[indexT])
                {
                    indexS++;
                }
                indexT++;
            }

            return indexS == s.Length;
        }
    }
}
