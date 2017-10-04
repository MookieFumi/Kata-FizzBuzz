namespace FizzBuzz.Impl
{
    public class FizzBuzzRule
    {
        public MatchingCondition MatchingCondition { get; }
        public string Translation { get; }

        public FizzBuzzRule(MatchingCondition matchingCondition, string translation)
        {
            MatchingCondition = matchingCondition;
            Translation = translation;
        }
    }
}