public class ListingActivity : Activity
{
    private List<string> _userList;
    private int _count;
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    public ListingActivity()
    {
        // set defaults
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 30;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> userList = new List<string>();

        while (DateTime.Now < endTime)
        {
            userList.AddRange(GetListFromUser());
        }
        _count = userList.Count;
        _userList = userList;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(1, _prompts.Count());
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        // initialize the list empty
        List<string> list = new List<string>();

        // get input from user
        string input = Console.ReadLine();

        // add input to list
        list.Add(input);

        return list;
    }

    // Getters
    public List<string> GetUserList()
    {
        return _userList;
    }
}

