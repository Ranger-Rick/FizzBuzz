using FizzBuzz;

namespace ClientApp.Rules;

public class Buzz : IFizzBuzzRule
{
    public string? AppendValue => "Buzz";
    public bool Evaluate(int currentValue)
    {
        if (currentValue is 0) return false;
        return currentValue % 5 == 0;
    }
}