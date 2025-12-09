public class EternalGoal : Goal
{
    private int _amountCompleted; // - Keep track of the times an EternalGoal is recorded
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"[{_amountCompleted}] {_shortName} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:|{_shortName}|{_description}|{_points}|false|0|0|{_amountCompleted}";
    }

    // setters&getters
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}