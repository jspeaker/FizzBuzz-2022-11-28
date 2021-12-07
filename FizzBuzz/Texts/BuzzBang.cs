namespace FizzBuzz.Texts;

public class BuzzBang : Text
{
    private static readonly Lazy<BuzzBang> _lazy = new(() => new BuzzBang());

    private BuzzBang() : base($"{(string)Buzz.Text()}{(string)Bang.Text()}") { }

    public static BuzzBang Text() => _lazy.Value;
}