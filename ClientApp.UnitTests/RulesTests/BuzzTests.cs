using ClientApp.Rules;

namespace ClientApp.UnitTests.RulesTests;

public class BuzzTests
{
    [Theory]
    [InlineData(0, false)]
    [InlineData(7, false)]
    [InlineData(5, true)]
    [InlineData(42, false)]
    [InlineData(25, true)]
    [InlineData(15, true)]
    [InlineData(555555, true)]
    public void Buzz_ShouldEvaluate(int input, bool expectedEvaluation)
    {
        var buzz = new Buzz();

        var evaluationResult = buzz.Evaluate(input);
        
        Assert.Equal(expectedEvaluation, evaluationResult);
    }

    [Fact]
    public void Buzz_ShouldReturnBuzz()
    {
        var fizz = new Buzz();
        
        Assert.Equal("Buzz", fizz.AppendValue);
    }
}