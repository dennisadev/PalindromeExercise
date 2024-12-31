using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("fail", false)]
        [InlineData("kayak", true)]
        public void Test1(string word, bool expected)
        {
            //Arange
            var wordSmithTest = new WordSmith();
            //Act
            var actual = wordSmithTest.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
            
        }
    }
}
