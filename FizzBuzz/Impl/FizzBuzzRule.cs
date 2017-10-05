using System;

namespace FizzBuzz.Impl
{
    public class FizzBuzzRule
    {
        public Func<int, bool> MatchingCondition { get; }
        public string Translation { get; }

        public FizzBuzzRule(Func<int, bool> matchingCondition, string translation)
        {
            MatchingCondition = matchingCondition;
            Translation = translation;
        }
    }
}