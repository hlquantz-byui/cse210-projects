public class ChecklistGoal : Goal
{
    private int _amountCompleted, _target, _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        _amountCompleted++;
    }

    public override int GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return base.GetPoints() + _bonus;
        }
        else
        {
            return base.GetPoints();
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target ? true : false;
    }


    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $" -- Currently completed: {_amountCompleted}/{_target}";
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetBonus()
    {
        return _bonus;
    }

    public void SetCompleted(int amount)
    {
        _amountCompleted = amount;
    }

}