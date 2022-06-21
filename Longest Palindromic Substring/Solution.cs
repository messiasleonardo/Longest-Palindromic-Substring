using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            char[] convertString = s.ToArray();
            string invertString = "";
            for (int i = convertString.Length - 1; i >= 0; i--)
            {
                invertString += $"{convertString[i]}";
            }

            string logeststring = "";
            int count = 0;
            int totalString = 0;
            string result = "";



            char[] invertStringArray = invertString.ToArray();

            for (int i = 0; i <= invertString.Length - 1; i++)
            {
                for (int x = 0; x <= invertString.Length - 1; x++)
                {
                    if (invertStringArray[i] == convertString[x])
                    {
                        for (int z = i, a = x; z <= invertString.Length - 1; z++, a++)
                        {
                            if (z > invertString.Length - 1 || a > invertString.Length - 1)
                            {
                                break;
                            }
                            else
                            {
                                if (invertStringArray[z] == convertString[a])
                                {
                                    count++;
                                    logeststring += $"{invertStringArray[z]}";
                                }
                                else
                                {
                                    count = 0;
                                    logeststring = "";
                                }
                                if (count > totalString)
                                {
                                    result = logeststring;
                                    totalString = count;

                                }
                            }
                        }
                        logeststring = "";
                        count = 0;
                    }
                }

            }

            return result;


        }

        
    }
}
