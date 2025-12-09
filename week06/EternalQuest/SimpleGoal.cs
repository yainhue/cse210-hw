using System.Drawing;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
        // 
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:|{_shortName}|{_description}|{_points}|{_isComplete}|0|0|0";
    }


    // setters&getters
    public void SetStatus(bool status)
    {
        _isComplete = status;
    }
}