using FizzBuzz;

namespace ClientApp.Rules;

public class ContainsSeven : IFizzBuzzRule
{
    public string? AppendValue => "Contains Seven";
    public bool Evaluate(int currentValue)
    {
        var number = currentValue.ToString();
        return number.Contains("7");
    }
}