using FizzBuzz.Extensions;
using FizzBuzz.Texts;

namespace FizzBuzz.Strategies
{
    public class BuzzBangStrategy : IFizzBuzzString
    {
        private readonly int _value;
        private readonly IFizzBuzzString _nextStrategy;

        public BuzzBangStrategy(int value, IFizzBuzzString nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public string AsString()
        {
            if (_value is 35) return BuzzBang.Text();
            return _nextStrategy.AsString();
        }
    }
}