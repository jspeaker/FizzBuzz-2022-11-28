using FizzBuzz.Extensions;
using FizzBuzz.Texts;

namespace FizzBuzz.Strategies
{
    public class FizzBangStrategy : IFizzBuzzString
    {
        private readonly int _value;
        private readonly IFizzBuzzString _nextStrategy;

        public FizzBangStrategy(int value, IFizzBuzzString nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public string AsString()
        {
            if (_value is 21) return FizzBang.Text();
            return _nextStrategy.AsString();
        }
    }
}