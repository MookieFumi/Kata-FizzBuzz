using System.Linq;

namespace FizzBuzz.Impl
{
    public class FizzBuzz
    {
        private readonly FizzBuzzRule[] _rules;

        public FizzBuzz(IFizzBuzzRuleFactory fizzBuzzRuleFactory)
        {
            _rules = fizzBuzzRuleFactory.Create();
        }

        public string Translate(int number)
        {
            var expected = _rules.FirstOrDefault(p => p.MatchingCondition(number));
            return expected == null ? number.ToString() : expected.Translation;
        }
    }
}