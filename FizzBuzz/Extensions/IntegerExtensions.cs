namespace FizzBuzz.Extensions
{
    public static class IntegerExtensions
    {
        public static bool EvenlyDivisibleBy(this int instance, int divisor) => instance % divisor == 0;
    }
}