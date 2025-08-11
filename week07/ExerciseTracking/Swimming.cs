using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert meters to miles: 50m per lap, 1609m per mile
        return (_laps * 50) / 1609.34;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }
}
