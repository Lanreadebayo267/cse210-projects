public class Player
{
    public int Score { get; private set; }
    public int Level => Score / 1000;
    private List<string> _badges = new List<string>();

    public void AddPoints(int points)
    {
        int oldLevel = Level;
        Score += points;

        if (Level > oldLevel)
        {
            Console.WriteLine($"🎉 You've leveled up! You're now level {Level}!");
        }

        // Simple badge logic
        if (Score >= 1000 && !_badges.Contains("Beginner"))
        {
            _badges.Add("Beginner");
            Console.WriteLine("🏅 Badge Unlocked: Beginner!");
        }
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Current Score: {Score} | Level: {Level}");
        Console.WriteLine("Badges: " + (_badges.Count > 0 ? string.Join(", ", _badges) : "None"));
    }

    public string GetSaveString()
    {
        return $"{Score}";
    }

    public void LoadFromString(string scoreStr)
    {
        Score = int.Parse(scoreStr);
    }
}
