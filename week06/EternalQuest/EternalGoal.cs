public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(Player player)
    {
        player.AddPoints(_points);
        Console.WriteLine($"You recorded: {_name}. Gained {_points} points!");
    }

    public override bool IsComplete() => false;

    public override void DisplayGoal()
    {
        Console.WriteLine($"[∞] {_name} ({_description})");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}";
    }
}
