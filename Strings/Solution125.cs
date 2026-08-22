namespace LeetCode.Strings
{
    public class Solution125
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (char.IsLetterOrDigit(s[left]))
                {
                    if (char.IsLetterOrDigit(s[right]))
                    {
                        char a = char.ToLowerInvariant(s[left]);
                        char b = char.ToLowerInvariant(s[right]);
                        if(a != b)
                        {
                            return false;
                        }
                        else
                        {
                            left++;
                            right--;
                        }
                    }
                    else
                    {
                        right--;
                    }
                }
                else
                {
                    left++;
                }
            }
            return true;
        }
    }
}
