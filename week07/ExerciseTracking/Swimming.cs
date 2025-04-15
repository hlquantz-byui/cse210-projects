public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int minutes, int numLaps) : base(date, minutes)
    {
        _numberOfLaps = numLaps;
    }
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
}