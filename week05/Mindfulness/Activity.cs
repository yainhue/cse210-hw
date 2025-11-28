using System.Data;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string input = Console.ReadLine();
        if (input != "")
        {
            int duration = int.Parse(input);
            _duration = duration;
        }
        else
        {
        }

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(1);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '—', '\\', '|', '/', '—', '\\' };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (var s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(400);
                Console.Write("\r");
            }
            Console.Write("\b \b");

        }
        Console.Write("\b \b");
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write($"{seconds - i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    // Getters
    public string GetName()
    {
        return _name;
    }
    public int GetDuration()
    {
        return _duration;
    }
}