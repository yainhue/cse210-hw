

public class WrittingAssigment : Assigment
{
    private string _title;
    public WrittingAssigment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}\n{_title}";
    }
}