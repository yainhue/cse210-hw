// Word Class 

public class Word
{
    private string _text;
    private bool _isHidden;
    // private string _textCopy = _text;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }

    public void Hide()
    {
        _isHidden = true;
        for (int i = 0; i < _text.Count(); i++)
        {
            char[] _char = _text.ToCharArray();
            _char[i] = '_';
            _text = new string(_char);
        }

    }
    public void Show()
    {
        _isHidden = false;
        // _text = _textCopy;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}