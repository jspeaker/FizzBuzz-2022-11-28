namespace FizzBuzz.Texts
{
    public class Buzz : Text
    {
        private static readonly Lazy<Buzz> _lazy = new(() => new Buzz());

        private Buzz() : base("Buzz") { }

        public static Buzz Text() => _lazy.Value;
    }
}