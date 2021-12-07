namespace FizzBuzz.Texts;

public class Bang : Text
{
    private static readonly Lazy<Bang> _lazy = new(() => new Bang());

    private Bang() : base("Bang") { }

    public static Bang Text() => _lazy.Value;
}