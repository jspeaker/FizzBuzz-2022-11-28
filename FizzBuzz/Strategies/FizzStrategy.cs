using FizzBuzz.Extensions;
using FizzBuzz.Texts;

namespace FizzBuzz.Strategies
{
    public class FizzStrategy : IFizzBuzzString
    {
        private readonly int _value;
        private readonly IFizzBuzzString _nextStrategy;

        public FizzStrategy(int value, IFizzBuzzString nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public string AsString()
        {
            if (_value.EvenlyDivisibleBy(3)) return Fizz.Text();
            return _nextStrategy.AsString();
        }
    }
}