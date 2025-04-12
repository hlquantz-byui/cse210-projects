public abstract class Goal
{
    protected string _shortname, _description, _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }

    public virtual int GetPoints()
    {
        return int.Parse(_points);
    }
    public string GetShortName()
    {
        return _shortname;
    }
    public string GetDescription()
    {
        return _description;
    }

    public virtual void RecordEvent() { }

    public virtual bool IsComplete()
    {
        return false;
    }

    public string GetGoalDetails()
    {
        return $"{_shortname} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortname} ({_description})";
    }
}