using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    public int LengthMinutes => _lengthMinutes

    // Abstract methods (must be overridden in derived classes)
    public abstract double GetDistance(); // miles
    public abstract double GetSpeed(); // miles per hour
    public abstract double GetPace(); // minutees per mile

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthMinutes} min) - " +
                $"Distance {GetDistance():0.0} miles, " +
                $"Speed {GetSpeed():0.0} mph, " +
                $"Pace {GetPace():0.0} min per mile";
    }
}