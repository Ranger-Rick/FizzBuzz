namespace FizzBuzz.UnitTests;

public class MockFizzBuzzItem : IFizzBuzzRule
{
    public string? AppendValue { get; }
    private readonly int _divisor;

    public MockFizzBuzzItem(int divisor, string appendValue)
    {
        _divisor = divisor;
        AppendValue = appendValue;
    }
    public bool Evaluate(int currentValue)
    {
        return currentValue % _divisor == 0;
    }
}