public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    // gettters&setters
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
        // Speed = (distance / minutes) * 60
    }
    public override double GetPace()
    {
        return _length / _distance;
        // Pace (min per mile or min per km)= minutes / distance
    }



}

