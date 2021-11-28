using FizzBuzz;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_2022_11_28
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenIntNotEvenlyDivisibleByThreeOrFive_WhenAskingToString_ThenItShouldReturnIntAsString()
        {
            // arrange
            FizzBuzzString four = new(4);

            // act // assert
            ((string) four).Should().Be("4");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThree_WhenAskingToString_ThenItShouldReturnFizz()
        {
            // arrange
            FizzBuzzString nine = new(9);

            // act // assert
            ((string) nine).Should().Be("Fizz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByFive_WhenAskingToString_ThenItShouldReturnBuzz()
        {
            // arrange
            FizzBuzzString ten = new(10);

            // act // assert
            ((string) ten).Should().Be("Buzz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThreeAndFive_WhenAskingToString_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            FizzBuzzString thirty = new(30);

            // act // assert
            ((string) thirty).Should().Be("FizzBuzz");
        }
    }
}