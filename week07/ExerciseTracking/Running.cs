public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance / _minutes;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    // public override string GetSummary()
    // {
    //     return $"{_date.ToString("dd MMMM yyyy")} Running ({_minutes})- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, pace: {GetPace()} min per mile";
    // }
}