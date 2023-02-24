using FizzBuzz;

namespace ClientApp.Rules;

public class Fizz : IFizzBuzzRule
{
    public string? AppendValue => "Fizz";
    public bool Evaluate(int currentValue)
    {
        if (currentValue is 0) return false;
        return currentValue % 3 == 0;
    }
}