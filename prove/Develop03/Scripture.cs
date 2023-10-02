class Scripture
{
    //variables
    private Reference _reference;
    private List<Word> _words;

    //constructors
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = scriptureText.Split(' ');

        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        foreach (Word word in _words)
        {
            if (random.Next(2) == 0) // Randomly hide words
            {
                word.Hide();
            }
        }
    }

    //getset
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}

class Word
{
    //variables
    private string _text;
    private bool _isHidden;

    //constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    //getset
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }
}

class Reference
{
    //variables
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    //constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    //getset
    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}
