using Longest_Palindromic_Substring;
using Xunit;

namespace LongestPalindromeTests
{
    public class LongestPalindrome
    {
        [Theory]
        [InlineData("babad","bab")]
        [InlineData("cbbd","bb")]
        [InlineData("a","a")]
        [InlineData("ac","a")]
        [InlineData("bb","bb")]
        [InlineData("aacabdkacaa", "aca")]
        [InlineData("aabbbaa", "aabbbaa")]
        public void TestStrings(string s, string expected)
        {
            Solution solution = new Solution();
            //Act
            var actual = solution.LongestPalindrome(s);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}