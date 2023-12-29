using System.ComponentModel;
using Cocona;


public record CommonParameters(
    [Option('t', Description = "Choose between: coin, boolean, life")]
    string Type = "coin"
) : ICommandParameterSet;


public class TossCommands
{
    [Command("toss")]
    public void Toss(CommonParameters commonParams)
    {
        var trueObj = String.Empty;
        var falseObj = String.Empty;

        switch (commonParams.Type)
        {
            case "coin":
                trueObj = "heads";
                falseObj = "tails";
                break;
            case "boolean":
                trueObj = "true";
                falseObj = "false";
                break;
            case "life":
                trueObj = "life";
                falseObj = "death";
                break;
            default:
                Console.WriteLine("Invalid object");
                return;
        }

        var random = new Random();

        var coin = random.Next(0, 2) == 0 ? trueObj : falseObj;

        Console.WriteLine($"{coin}");
    }
}