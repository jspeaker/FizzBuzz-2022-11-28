namespace FizzBuzz.Texts;

public class FizzBuzzBang : Text
{
    private static readonly Lazy<FizzBuzzBang> _lazy = new(() => new FizzBuzzBang());

    private FizzBuzzBang() : base($"{(string)Fizz.Text()}{(string)Buzz.Text()}{(string)Bang.Text()}") { }

    public static FizzBuzzBang Text() => _lazy.Value;
}