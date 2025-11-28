public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        // set defaults
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 30;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Breathe out...");
            ShowCountdown(5);
        }
        DisplayEndingMessage();
    }
}