using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
                
         [Theory]
         [InlineData("racecar", true)]
         [InlineData("hello", false)]
         [InlineData("Racecar", false)]

        public void MyTest(string word, bool expected)
         {
             //arrange
             var tester = new Palindrome();

             //act
             bool actual = tester.IsAPalidrome(word);

             //assert
             Assert.Equal(expected, actual);
         }

    }
}
