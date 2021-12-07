using FizzBuzz.Extensions;
using FizzBuzz.Texts;

namespace FizzBuzz.Strategies
{
    public class BangStrategy : IFizzBuzzString
    {
        private readonly int _value;
        private readonly IFizzBuzzString _nextStrategy;

        public BangStrategy(int value, IFizzBuzzString nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public string AsString()
        {
            if (_value is 7) return Bang.Text();
            return _nextStrategy.AsString();
        }
    }
}