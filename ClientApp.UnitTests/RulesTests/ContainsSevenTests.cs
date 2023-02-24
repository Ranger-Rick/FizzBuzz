using ClientApp.Rules;

namespace ClientApp.UnitTests.RulesTests;

public class ContainsSevenTests
{
    [Theory]
    [InlineData(0, false)]
    [InlineData(5, false)]
    [InlineData(42, false)]
    [InlineData(25, false)]
    [InlineData(14, false)]
    [InlineData(7, true)]
    [InlineData(557555, true)]
    [InlineData(755555, true)]
    [InlineData(555557, true)]
    public void ContainsSeven_ShouldEvaluate(int input, bool expectedEvaluation)
    {
        var seven = new ContainsSeven();

        var evaluationResult = seven.Evaluate(input);
        
        Assert.Equal(expectedEvaluation, evaluationResult);
    }

    [Fact]
    public void ContainsSeven_ShouldReturnContainsSeven()
    {
        var fizz = new ContainsSeven();
        
        Assert.Equal("Contains Seven", fizz.AppendValue);
    }
}