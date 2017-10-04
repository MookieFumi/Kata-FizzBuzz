using FizzBuzz.Impl;
using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        private readonly Impl.FizzBuzz _sut;

        public FizzBuzzShould()
        {
            _sut = new Impl.FizzBuzz(new FizzBuzzRuleFactory());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(101)]
        [InlineData(203)]
        public void return_1_when_param_is_1(int number)
        {
            var result = _sut.Translate(number);
            result.Should().Be(number.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(123)]
        public void return_fizz_when_param_is_divisible_by_3(int number)
        {
            var result = _sut.Translate(number);
            result.Should().Be("fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(200)]
        public void return_buzz_when_param_is_divisible_by_5(int number)
        {
            var result = _sut.Translate(number);
            result.Should().Be("buzz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(315)]
        public void return_fizzbuzz_when_param_is_divisible_by_3_and_5(int number)
        {
            var result = _sut.Translate(number);
            result.Should().Be("fizzbuzz");
        }
    }
}