// Scripture Class 

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // handle string to Word conversion
        string[] word = text.Split(' ');
        foreach (var w in word)
        {
            Word word_instance = new Word(w);
            _words.Add(word_instance);
        }
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (var w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        return false;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        List<Word> notHidden = new List<Word>();

        // randomly select from only those words that are not already hidden
        foreach (var w in _words)
        {
            if (w.IsHidden() == false)
            {
                notHidden.Add(w);
            }
            else
            {
                notHidden.Remove(w);
            }
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (notHidden.Count > 1)
            {
                int rnd_index = rnd.Next(1, notHidden.Count() - 1);
                notHidden[rnd_index].Hide();
                notHidden.Remove(notHidden[rnd_index]);
            }
            else if (notHidden.Count == 1)
            {
                notHidden[0].Hide();
                notHidden.Remove(notHidden[0]);
            }
            else
            {
            }
        }


    }

    public void Unhide()
    {
        foreach (var w in _words)
        {
            w.Show();
        }
    }
}