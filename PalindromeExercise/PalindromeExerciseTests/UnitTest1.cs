using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("KaYaK", true)]
        [InlineData("madam", true)]
        [InlineData("potato", false)]
        [InlineData("hello", false)]
        [InlineData("RaCeCaR", true)]// ← you will need to put some test data and expected result here.

        public void PalindromeTester(string values, bool expected)
        {
            var tester = new WordSmith();

            bool actual = tester.IsAPalindrome(values);

            Assert.Equal(expected, actual);
        }
        // For example [InlineData(“racecar”, true)]
    }
}
