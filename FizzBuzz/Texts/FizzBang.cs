namespace FizzBuzz.Texts;

public class FizzBang : Text
{
    private static readonly Lazy<FizzBang> _lazy = new(() => new FizzBang());

    private FizzBang() : base("FizzBang") { }

    public static FizzBang Text() => _lazy.Value;
}