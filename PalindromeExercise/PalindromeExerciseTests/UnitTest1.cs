using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("racecar", true)]
        [InlineData ("mom", true)]
        [InlineData ("kayak", true)]
        [InlineData ("suzie", false)]

        public void IsAPalindromeTest(string word1, bool expected)
        {
            //Arrange
            WordSmith challenger = new WordSmith();
            //Act
            bool actual = challenger.IsAPalindrome(word1);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
