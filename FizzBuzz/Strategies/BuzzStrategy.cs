using FizzBuzz.Extensions;
using FizzBuzz.Texts;

namespace FizzBuzz.Strategies
{
    public class BuzzStrategy : IFizzBuzzString
    {
        private readonly int _value;
        private readonly IFizzBuzzString _nextStrategy;

        public BuzzStrategy(int value, IFizzBuzzString nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public string AsString()
        {
            if (_value.EvenlyDivisibleBy(5)) return Buzz.Text();
            return _nextStrategy.AsString();
        }
    }
}