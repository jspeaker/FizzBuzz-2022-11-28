using FizzBuzz.Strategies;

namespace FizzBuzz
{
    public class FizzBuzzString : IFizzBuzzString
    {
        private readonly IFizzBuzzString _strategyChain;

        public FizzBuzzString(int value) :
            this(new FizzBuzzBangStrategy(value, 
                new FizzBuzzStrategy(value,
                    new BuzzBangStrategy(value,
                        new BuzzStrategy(value,
                            new FizzBangStrategy(value,
                                new FizzStrategy(value,
                                    new BangStrategy(value,
                                        new StringStrategy(value))))))))) { }

        private FizzBuzzString(IFizzBuzzString strategyChain) => _strategyChain = strategyChain;

        public static implicit operator string(FizzBuzzString fizzBuzzString) => fizzBuzzString.AsString();

        public string AsString() => _strategyChain.AsString();
    }
}