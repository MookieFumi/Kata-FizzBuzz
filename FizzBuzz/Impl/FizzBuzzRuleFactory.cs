using System.Linq;

namespace FizzBuzz.Impl
{
    public class FizzBuzzRuleFactory : IFizzBuzzRuleFactory
    {
        private const string Fizzbuzz = "fizzbuzz";
        private const string Fizz = "fizz";
        private const string Buzz = "buzz";

        public FizzBuzzRule[] Create()
        {
            return new[]
            {
                new FizzBuzzRule(v => IsDivisibleBy(v, 3, 5), Fizzbuzz),
                new FizzBuzzRule(v => IsDivisibleBy(v, 3), Fizz),
                new FizzBuzzRule(v => IsDivisibleBy(v, 5), Buzz)
            };
        }

        private static bool IsDivisibleBy(int number, params int[] values)
        {
            return values.All(value => number % value == 0);
        }
    }
}