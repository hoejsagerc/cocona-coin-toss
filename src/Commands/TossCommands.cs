using Cocona;

public class TossCommands
{
    [Command("toss")]
    public void Toss()
    {
        var random = new Random();

        var coin = random.Next(0, 2) == 0 ? "heads" : "tails";

        Console.WriteLine($"{coin}");
    }
}