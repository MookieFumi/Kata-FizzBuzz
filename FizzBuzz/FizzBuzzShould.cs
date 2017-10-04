using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        [Fact]
        public void return_1_when_param_is_1()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Translate(1);
            result.Should().Be("1");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void return_fizz_when_param_is_divisible_by_3(int number)
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Translate(number);
            result.Should().Be("fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void return_buzz_when_param_is_divisible_by_5(int number)
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Translate(number);
            result.Should().Be("buzz");
        }

        [Theory]
        [InlineData(15)]
        public void return_fizzbuzz_when_param_is_divisible_by_3_and_5(int number)
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Translate(number);
            result.Should().Be("fizzbuzz");
        }
    }

    public class FizzBuzz
    {
        public string Translate(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbuzz";
            }

            if (number % 3 == 0)
            {
                return "fizz";
            }
            if (number % 5 == 0)
            {
                return "buzz";
            }
            return number.ToString();
        }
    }
}
