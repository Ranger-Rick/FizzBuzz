using FizzBuzz;

namespace ClientApp.Rules;

public class TheAnswerToLifeTheUniverseAndEverything : IFizzBuzzRule
{
    public string? AppendValue => "~The Answer to life, the universe, and everything~";
    public bool Evaluate(int currentValue)
    {
        //What is the answer?
        return currentValue == 42;
    }
}