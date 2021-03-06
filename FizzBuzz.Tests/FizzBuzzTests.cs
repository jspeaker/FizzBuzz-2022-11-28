using FizzBuzz;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_2022_11_28
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenIntNotEvenlyDivisibleByThreeOrFive_WhenImplicitlyGettingString_ThenItShouldReturnIntAsString()
        {
            // arrange
            FizzBuzzString four = new(4);

            // act 
            string actual = four;

            // assert
            actual.Should().Be("4");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThree_WhenImplicitlyGettingString_ThenItShouldReturnFizz()
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
        public void GivenIntEvenlyDivisibleByThreeAndFive_WhenImplicitlyGettingString_ThenItShouldReturnFizzBuzz()
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