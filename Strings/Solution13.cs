using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public class Solution13
    {
        public int RomanToInt(string s)
        {
            int total = 0;
            Dictionary<char, int> roman = new Dictionary<char, int>();

            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (roman[s[i]] < roman[s[i + 1]])
                {
                    total -= roman[s[i]];
                }
                else
                {
                    total += roman[s[i]];
                }
            }

            return total + roman[s.Last()];
        }
    }
}
