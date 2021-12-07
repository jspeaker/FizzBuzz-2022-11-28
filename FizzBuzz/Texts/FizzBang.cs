namespace FizzBuzz.Texts;

public class FizzBang : Text
{
    private static readonly Lazy<FizzBang> _lazy = new(() => new FizzBang());

    private FizzBang() : base($"{(string)Fizz.Text()}{(string)Bang.Text()}") { }

    public static FizzBang Text() => _lazy.Value;
}