using FizzBuzz.Extensions;

namespace FizzBuzz.Strategies
{
    public class FizzBuzzStrategy : IFizzBuzzString
    {
        private readonly int _value;
        private readonly IFizzBuzzString _nextStrategy;

        public FizzBuzzStrategy(int value, IFizzBuzzString nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public string AsString()
        {
            if (_value.EvenlyDivisibleBy(3) && _value.EvenlyDivisibleBy(5)) return Texts.FizzBuzz.Text();
            return _nextStrategy.AsString();
        }
    }
}