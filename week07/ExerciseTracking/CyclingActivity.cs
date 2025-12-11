public class CyclingActivity : Activity
{
   private double _speed;

   public CyclingActivity(double length, double speed) : base(length)
   {
      _speed = speed;
   }

   // gettters&setters
   public override double GetDistance()
   {
      return _speed * (_length / 60);
   }

   public override double GetSpeed()
   {
      return _speed;
   }
   public override double GetPace()
   {
      return 60 / _speed;
      // Pace = 60 / speed
   }
}

