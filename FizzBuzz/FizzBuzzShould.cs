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
    }

    public class FizzBuzz
    {
        public string Translate(int number)
        {
            return number.ToString();
        }
    }
}
