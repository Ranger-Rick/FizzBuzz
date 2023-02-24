namespace FizzBuzz.UnitTests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(7, "7")]
    [InlineData(100, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(300, "FizzBuzz")]
    private async Task FizzBuzzPlayer_ShouldObeyRules(int upperLimit, string expectedLastValue)
    {
        var mockRules = GetRules();
        var player = new FizzBuzzPlayer(mockRules);

        var results = await player.Play(upperLimit);
        var actualLastValue = results.Last();
        
        Assert.Equal(expectedLastValue, actualLastValue);
    }

    [Fact]
    private async Task FizzBuzzPlayer_HandlesZero()
    {
        var player = new FizzBuzzPlayer();

        var result = await player.Play(0);
        
        Assert.Equal(0, result.Count());

    }
    

    private static IEnumerable<IFizzBuzzRule> GetRules()
    {
        var fizz = new MockFizzBuzzItem(3, "Fizz");
        var buzz = new MockFizzBuzzItem(5, "Buzz");
        var output = new List<IFizzBuzzRule>
        {
            fizz,
            buzz
        };
        return output;
    }
}