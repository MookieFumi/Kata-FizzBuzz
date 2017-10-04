﻿using FluentAssertions;
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

        [Fact]
        public void return_fizz_when_param_is_divisible_by_3()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Translate(3);
            result.Should().Be("fizz");
        }
    }

    public class FizzBuzz
    {
        public string Translate(int number)
        {
            if (number % 3 == 0)
            {
                return "fizz";
            }
            return number.ToString();
        }
    }
}
