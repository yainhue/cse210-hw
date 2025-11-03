/*
Class: Resume

    Responsibilities:
        Keeps track of the person's name and a list of their jobs.
    Behaviors:
        Displays the resume, which shows the name first, followed by displaying each one of the jobs.
*/

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // print cada objeto job in la lista "_jobs"
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //  Notice the use of the custom data type "Job" in this loop
        foreach (Job j in _jobs)
        {
            // This calls the Display method on each job
            j.Display();
        }
    }
}