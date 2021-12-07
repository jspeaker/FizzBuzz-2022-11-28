using FizzBuzz;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_2022_11_28
{
    [TestClass]
    public class FizzBuzzStringTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenIntNotEvenlyDivisibleByThreeOrFiveOrSeven_WhenImplicitlyGettingString_ThenItShouldReturnIntAsString()
        {
            // arrange
            FizzBuzzString four = new(4);

            // act 
            string actual = four;

            // assert
            actual.Should().Be("4");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleBySeven_WhenImplicitlyGettingString_ThenItShouldReturnBang()
        {
            // arrange
            FizzBuzzString fourteen = new(14);

            // act 
            string actual = fourteen;

            // assert
            actual.Should().Be("Bang");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThreeAndSevenButNotFive_WhenImplicitlyGettingString_ThenItShouldReturnFizzBang()
        {
            // arrange
            FizzBuzzString fortyTwo = new(42);

            // act 
            string actual = fortyTwo;

            // assert
            actual.Should().Be("FizzBang");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByFiveAndSevenButNotThree_WhenImplicitlyGettingString_ThenItShouldReturnBuzzBang()
        {
            // arrange
            FizzBuzzString seventy = new(70);

            // act 
            string actual = seventy;

            // assert
            actual.Should().Be("BuzzBang");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThreeButNotFiveOrSeven_WhenImplicitlyGettingString_ThenItShouldReturnFizz()
        {
            // arrange
            FizzBuzzString nine = new(9);

            // act
            string actual = nine;
            
            // assert
            actual.Should().Be("Fizz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByFiveButNotThreeOrSeven_WhenImplicitlyGettingString_ThenItShouldReturnBuzz()
        {
            // arrange
            FizzBuzzString ten = new(10);

            // act
            string actual = ten;

            // assert
            actual.Should().Be("Buzz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThreeAndFiveButNotSeven_WhenImplicitlyGettingString_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            FizzBuzzString thirty = new(30);

            // act // assert
            string actual = thirty;
            
            // assert
            actual.Should().Be("FizzBuzz");
        }

        [TestMethod, TestCategory("Unit")]
        public void GivenIntEvenlyDivisibleByThreeAndFiveAndSeven_WhenImplicitlyGettingString_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            FizzBuzzString twoHundredAndTen = new(210);

            // act // assert
            string actual = twoHundredAndTen;
            
            // assert
            actual.Should().Be("FizzBuzzBang");
        }
    }
}