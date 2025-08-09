public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent(Player player)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            player.AddPoints(_points);
            Console.WriteLine($"You completed: {_name}. Gained {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override void DisplayGoal()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{checkbox} {_name} ({_description})");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name}|{_description}|{_points}|{_isComplete}";
    }
}