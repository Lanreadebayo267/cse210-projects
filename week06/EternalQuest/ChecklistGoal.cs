public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int targetCount, int completedCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _completedCount = completedCount;
        _bonus = bonus;
    }

    public override void RecordEvent(Player player)
    {
        if (_completedCount < _targetCount)
        {
            _completedCount++;
            player.AddPoints(_points);
            Console.WriteLine($"Progress made on {_name}: {_completedCount}/{_targetCount} — Gained {_points} points!");

            if (_completedCount == _targetCount)
            {
                player.AddPoints(_bonus);
                Console.WriteLine($"🎉 Bonus complete! You gained an extra {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already completed.");
        }
    }

    public override bool IsComplete() => _completedCount >= _targetCount;

    public override void DisplayGoal()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{checkbox} {_name} ({_description}) — Completed {_completedCount}/{_targetCount}");
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_completedCount}";
    }
}
 
 