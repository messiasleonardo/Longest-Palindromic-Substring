using Longest_Palindromic_Substring;
using Xunit;

namespace LongestPalindromeTests
{
    public class LongestPalindrome
    {
        [Theory]
        [InlineData("babad","aba")]
        [InlineData("cbbd","bb")]
        [InlineData("a","a")]
        [InlineData("ac","c")]
        [InlineData("lkjhabanu","aba")]
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