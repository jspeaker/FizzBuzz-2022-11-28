namespace FizzBuzz.Texts
{
    public class FizzBuzz : Text
    {
        private static readonly Lazy<FizzBuzz> _lazy = new(() => new FizzBuzz());

        private FizzBuzz() : base("FizzBuzz") { }

        public static FizzBuzz Text() => _lazy.Value;
    }
}