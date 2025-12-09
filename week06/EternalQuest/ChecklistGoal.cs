public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted += 1;
        }
        else
        {
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public override string GetDetailsString()
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description}) - {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {_shortName} ({_description}) - {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        if (!IsComplete())
        {
            return $"ChecklistGoal:|{_shortName}|{_description}|{_points}|False|{_bonus}|{_target}|{_amountCompleted}";
        }
        else
        {
            return $"ChecklistGoal:|{_shortName}|{_description}|{_points}|True|{_bonus}|{_target}|{_amountCompleted}";
        }

    }

    // setters&getters

    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}