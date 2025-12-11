public abstract class Activity
{
    private string _date;
    protected double _length;
    // lenght in minutes

    public Activity(double length)
    {
        DateTime now = DateTime.Now;
        _date = now.ToString("dd MMM yyyy");
        _length = length;
    }

    public string GetSummary()
    {
        // 3 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km

        if (this is RunningActivity)
        {
            return $"{_date} Running ({_length} min): Distance: {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }
        else if (this is SwimmingActivity)
        {
            return $"{_date} Swimming ({_length} min): Distance: {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }
        else if (this is CyclingActivity)
        {
            return $"{_date} Running ({_length} min): Distance: {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }
        else
        {
            return "Invalid class type";
        }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}



// Math tips:

// Distance (km) = swimming laps * 50 / 1000
// Speed (mph or kph) = (distance / minutes) * 60
// Pace (min per mile or min per km)= minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed