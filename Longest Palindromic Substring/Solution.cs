using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindromic_Substring
{
    public class Solution
    {
        int start = 0;
        int lenght = 0;
        public string LongestPalindrome(string s)
        {
            if (s == null || s.Length <= 1)
            {
                return s;
            }


            for (int i = 0; i < s.Length; i++)
            {
                ExpandFromMiddle(s, i, i);
                ExpandFromMiddle(s, i, i + 1);
            }
            return s.Substring(start, start + lenght);
        }


        private void ExpandFromMiddle(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length && s[i].Equals(s[j]))
            {
                i--;
                j++;
            }
            if (j - i - 1 > lenght)
            {
                lenght = j - i - 1;
                start = i + 1;
            }
        }
    }
}
