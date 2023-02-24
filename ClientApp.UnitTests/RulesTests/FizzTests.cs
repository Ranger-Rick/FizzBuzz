using ClientApp.Rules;

namespace ClientApp.UnitTests.RulesTests;

public class FizzTests
{
    [Theory]
    [InlineData(0, false)]
    [InlineData(7, false)]
    [InlineData(5, false)]
    [InlineData(42, true)]
    [InlineData(3, true)]
    [InlineData(6, true)]
    [InlineData(333333, true)]
    public void Fizz_ShouldEvaluate(int input, bool expectedEvaluation)
    {
        var fizz = new Fizz();

        var evaluationResult = fizz.Evaluate(input);
        
        Assert.Equal(expectedEvaluation, evaluationResult);
    }

    [Fact]
    public void Fizz_ShouldReturnFizz()
    {
        var fizz = new Fizz();
        
        Assert.Equal("Fizz", fizz.AppendValue);
    }
}