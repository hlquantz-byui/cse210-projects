public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date.Date;
        _minutes = minutes;
    }

    public abstract double GetDistance();


    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        string activityType = GetType().Name;
        return $"{_date.ToString("dd MMMM yyyy")} {activityType} ({_minutes})- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, pace: {GetPace()} min per mile";
    }
}