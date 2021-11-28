namespace FizzBuzz.Strategies
{
    public class StringStrategy : IFizzBuzzString
    {
        private readonly int _value;
        public StringStrategy(int value) => _value = value;
        public string AsString() => _value.ToString();
    }
}