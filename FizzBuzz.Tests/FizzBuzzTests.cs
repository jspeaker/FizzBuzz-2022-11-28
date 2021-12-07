using FizzBuzz;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_2022_11_28
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenIntDoesNotMeetOtherBusinessRules_WhenImplicitlyGettingString_ThenItShouldReturnIntAsString()
        {
            // arrange
            FizzBuzzString four = new(4);

            // act 
            string actual = four;

            // assert
            actual.Should().Be("4");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenSeven_WhenImplicitlyGettingString_ThenItShouldReturnBang()
        {
            // arrange
            FizzBuzzString seven = new(7);

            // act 
            string actual = seven;

            // assert
            actual.Should().Be("Bang");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenTwentyOne_WhenImplicitlyGettingString_ThenItShouldReturnFizzBang()
        {
            // arrange
            FizzBuzzString twentyOne = new(21);

            // act 
            string actual = twentyOne;

            // assert
            actual.Should().Be("FizzBang");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThreeButNotTwentyOne_WhenImplicitlyGettingString_ThenItShouldReturnFizz()
        {
            // arrange
            FizzBuzzString nine = new(9);

            // act
            string actual = nine;
            
            // assert
            actual.Should().Be("Fizz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByFive_WhenImplicitlyGettingString_ThenItShouldReturnBuzz()
        {
            // arrange
            FizzBuzzString ten = new(10);

            // act
            string actual = ten;

            // assert
            actual.Should().Be("Buzz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThreeAndFiveButNotTwentyOne_WhenImplicitlyGettingString_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            FizzBuzzString thirty = new(30);

            // act // assert
            string actual = thirty;
            
            // assert
            actual.Should().Be("FizzBuzz");
        }
    }
}