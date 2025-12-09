/*
Journal

*Store each entry as part of a member attribute list, 
Display each entry as needed and Save and Load the 
journal from an user-named file.*

*/
using System.IO;
using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void DisplayAll()
    {
        Console.WriteLine("Entries:");

        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine("");
        }
    }

    public void AddEntry(Journal myJournal)
    {
        // prompt the user and store input
        PromptGenerator promptGen = new PromptGenerator();
        string prompt = promptGen.GeneratePrompt();
        Console.WriteLine($"{prompt}");
        string input = Console.ReadLine();

        // get the current date and store as string
        DateTime dateNow = DateTime.Now;
        String dateNowString = dateNow.ToString("dd-MM-yyyy HH:mm");

        // save values to a new entry instance
        Entry newEntry = new Entry();
        newEntry._promptText = prompt;
        newEntry._responseText = input;
        newEntry._date = dateNowString;

        // add new entry to list of entries
        myJournal._entries.Add(newEntry);
        Console.WriteLine("Entry succesfuly added!");
        Console.WriteLine("");
    }

    public void SaveToFile(Journal myJournal)
    {
        Console.WriteLine("Please enter a name for your file (no file extension requiered): ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputfile = new StreamWriter($"{fileName}.csv"))
        {
            outputfile.WriteLine("_shortName|_description|_points|_isComplete|_bonus|_target|_amountCompleted");
            foreach (Entry e in myJournal._entries)
            {
                outputfile.WriteLine($"{e._date}|'{e._promptText}'|'{e._responseText}'|");
                $"EternalGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
            }
        }
        Console.WriteLine($"Saved correctly to '{fileName}.csv'!");
        Console.WriteLine("");
    }
    public void LoadFromFile(Journal myJournal)
    {
        Console.WriteLine("Please enter the name of your file (no file extension requiered): ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.csv");

        //skip the header (first line)
        string header = lines[0];

        // foreach (string line in lines)
        // loops through the rest of the lines
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            // saves each part of each line in a variable
            string _date = parts[0];
            string _promptText = parts[1];
            string _responseText = parts[2];

            // save values to a new entry instance
            Entry newEntry = new Entry();
            newEntry._promptText = _promptText;
            newEntry._responseText = _responseText;
            newEntry._date = _date;

            // add new entry to list of entries
            myJournal._entries.Add(newEntry);
        }
        Console.WriteLine($"Loaded correctly from '{fileName}.csv'!");
        Console.WriteLine("");
    }
}