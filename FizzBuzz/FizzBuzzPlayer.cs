namespace FizzBuzz;

public class FizzBuzzPlayer
{
    private readonly IEnumerable<IFizzBuzzRule> _rules;
    private readonly int _batchSize;

    /// <summary>
    /// A Game Object that plays plays FizzBuzz. FizzBuzz is a game that iterates over a range of numbers, evaluates each
    /// one, and conditionally replaces the number with a string or combination of strings (depending on evaluation rules).
    /// </summary>
    /// <param name="rules">
    /// A list of <see cref="IFizzBuzzRule"/> that will be used to play FizzBuzz.
    /// </param>
    /// <param name="batchSize">
    /// An optional int to determine how many FizzBuzz evaluations occur at once.
    /// </param>
    public FizzBuzzPlayer(IEnumerable<IFizzBuzzRule>? rules = null, int batchSize = 11000000)
    {
        _rules = rules ?? new List<IFizzBuzzRule>();
        _batchSize = batchSize;
    }

    public async Task<IEnumerable<string>> Play(int upperLimit)
    {
        var tasks = new Dictionary<int, Task<IEnumerable<string>>>();

        for (var i = 1; i <= upperLimit + 1; i += _batchSize)
        {
            if (i <= 0) break;
            var localIndex = i;
            var task = Task.Run(() =>
            {
                var batch =
                    Enumerable.Range(localIndex, _batchSize)
                        .Where(x => x < upperLimit + 1);
                
                return PlayBatch(batch);
            });
            tasks.Add(i, task);
        }
        
        var results = await Task.WhenAll(tasks.Values);
        var output = new List<string>();
        foreach (var result in results)
        {
            output.AddRange(result);
        }
        
        return output;

    }

    private IEnumerable<string> PlayBatch(IEnumerable<int> numbers)
    {
        var output = new List<string>();
        foreach (var number in numbers)
        {
            var addItem = "";
            foreach (var rule in _rules)
            {
                if (!rule.Evaluate(number)) continue;

                addItem += rule.AppendValue;
            }

            if (string.IsNullOrEmpty(addItem))
            {
                addItem = number.ToString();
            }
            
            output.Add(addItem);
        }
        
        return output;
    }
}