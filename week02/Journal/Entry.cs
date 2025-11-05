/*
Entry

*Each entry is made up of a random prompt
that is shown to the user, their
response and the date.*

*/

public class Entry
{

    public string _promptText;
    public string _responseText;
    public string _date;
    public void Display()
    {
        Console.WriteLine($"{_date} - '{_promptText}'");
        Console.WriteLine($"Entry: {_responseText}");
    }
}
