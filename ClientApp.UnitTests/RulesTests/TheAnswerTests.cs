using ClientApp.Rules;

namespace ClientApp.UnitTests.RulesTests;

public class TheAnswerTests
{
    [Theory]
    [InlineData(41, false)]
    [InlineData(43, false)]
    [InlineData(0, false)]
    [InlineData(1, false)]
    [InlineData(42424242, false)]
    [InlineData(42, true)]
    public void TheAnswer_ShouldEvaluate(int input, bool expectedEvaluation)
    {
        var theAnswer = new TheAnswerToLifeTheUniverseAndEverything();

        var evaluationResult = theAnswer.Evaluate(input);
        
        Assert.Equal(expectedEvaluation, evaluationResult);
    }

    [Fact]
    public void TheAnswer_ShouldReturnAppendValue()
    {
        var theAnswer = new TheAnswerToLifeTheUniverseAndEverything();
        
        Assert.Equal("~The Answer to life, the universe, and everything~", theAnswer.AppendValue);
    }
}