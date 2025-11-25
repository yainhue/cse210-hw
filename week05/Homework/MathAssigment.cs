public class MathAssigment : Assigment
{
    private string _textbookSelection;
    private string _problems;

    public MathAssigment(string studentName, string topic, string textbookSelection, string problems) : base(studentName, topic)
    {
        _textbookSelection = textbookSelection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSelection} - {_problems}";
    }
}