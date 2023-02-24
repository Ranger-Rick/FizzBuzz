using ClientApp.Rules;
using FizzBuzz;

namespace ClientApp;

public class Program
{
    public static async Task Main(string[] args)
    {
        var fizz = new Fizz();
        var buzz = new Buzz();
        var seven = new ContainsSeven();
        var theAnswer = new TheAnswerToLifeTheUniverseAndEverything();

        var rules = new List<IFizzBuzzRule>
        {
            fizz,
            buzz,
            seven,
            theAnswer
        };
        
        var player = new FizzBuzzPlayer(rules);

        var results = await player.Play(50);

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}