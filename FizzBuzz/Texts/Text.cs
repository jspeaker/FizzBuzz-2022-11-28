namespace FizzBuzz.Texts
{
    public abstract class Text
    {
        private readonly string _value;

        protected Text(string value) => _value = value;

        public static implicit operator string (Text text) => text._value;
    }
}