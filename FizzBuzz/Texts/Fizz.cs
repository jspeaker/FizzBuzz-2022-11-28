namespace FizzBuzz.Texts
{
    public class Fizz : Text
    {
        private static readonly Lazy<Fizz> _lazy = new(() => new Fizz());

        private Fizz() : base("Fizz") { }

        public static Fizz Text() => _lazy.Value;
    }
}