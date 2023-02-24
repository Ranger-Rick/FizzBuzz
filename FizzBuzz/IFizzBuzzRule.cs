namespace FizzBuzz;

/// <summary>
/// A contract that allows clients to play FizzBuzz with custom rules / values.
/// </summary>
public interface IFizzBuzzRule
{
    /// <summary>
    /// The value to append to the output of the current FizzBuzz evaluation.
    /// </summary>
    /// <example>
    /// "Fizz" or "Buzz"
    /// </example>
    string? AppendValue { get; }
    
    /// <summary>
    /// Evaluate the current value of the FizzBuzz game. Clients can implement custom logic to determine if the
    /// <see cref="AppendValue"/> should be appended to the output.
    /// </summary>
    /// <param name="currentValue">The current value of the FizzBuzz game.</param>
    /// <returns>A bool which denotes if the <see cref="AppendValue"/> should be appended to the output</returns>
    bool Evaluate(int currentValue);
}