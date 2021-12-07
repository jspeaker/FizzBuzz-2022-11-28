using FizzBuzz.Extensions;
using FizzBuzz.Texts;

namespace FizzBuzz.Strategies
{
    public class FizzBuzzBangStrategy : IFizzBuzzString
    {
        private readonly int _value;
        private readonly IFizzBuzzString _nextStrategy;

        public FizzBuzzBangStrategy(int value, IFizzBuzzString nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public string AsString()
        {
            if (_value.EvenlyDivisibleBy(3) && _value.EvenlyDivisibleBy(5) && _value.EvenlyDivisibleBy(7)) return FizzBuzzBang.Text();
            return _nextStrategy.AsString();
        }
    }
}