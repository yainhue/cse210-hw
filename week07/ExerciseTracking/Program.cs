using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        List<Activity> list = new List<Activity>();

        CyclingActivity cycling = new CyclingActivity(30, 29);
        SwimmingActivity swimming = new SwimmingActivity(30, 7);
        RunningActivity running = new RunningActivity(30, 4.8);

        list.Add(cycling);
        list.Add(swimming);
        list.Add(running);

        foreach (var a in list)
        {
            Console.WriteLine(a.GetSummary());
        }
        Console.WriteLine();
    }
}