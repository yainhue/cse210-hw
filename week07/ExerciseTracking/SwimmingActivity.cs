public class SwimmingActivity : Activity
{
    private double _laps;
    // (the length of a lap in the lap pool is 50 meters.)

    public SwimmingActivity(double length, double laps) : base(length)
    {
        _laps = laps;
    }

    // gettters&setters
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
        // Distance (km) = swimming laps * 50 / 1000
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
        // Speed = (distance / minutes) * 60
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
        // Pace = 60 / speed
    }

    public double GetLaps()
    {
        return _laps;
    }





}


