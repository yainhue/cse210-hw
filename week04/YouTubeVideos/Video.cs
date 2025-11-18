using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _length = lenght;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public string GetComments()
    {
        string accumulator = "";
        foreach (var c in _comments)
        {
            string author = c.GetAuthor();
            string text = c.GetText();
            accumulator += $"\n'{text}'\n  - {author}\n";
        }
        return accumulator;
    }

    public string GetDisplayText()
    {
        int countComments = _comments.Count();
        return $"---\n{_title} - {_length} seconds\nBy: {_author}\n Comments:{countComments}\n";
    }
}

