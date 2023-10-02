using System;

class Scripture
{
    //variables, use array instead of list? 
    private Reference _reference;
    private Word[] _words;

    //constructors
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        string[] wordArray = scriptureText.Split(' ');

        _words = new Word[wordArray.Length];
        for (int i = 0; i < wordArray.Length; i++)
        {
            _words[i] = new Word(wordArray[i]);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(0, _words.Length);

            if (randomIndex < _words.Length)
            {
                _words[randomIndex].Hide();
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
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
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
        this._text = text;
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

    public Reference(string book)
    {
        _book = book;
        _chapter = 1;
        _startVerse = 1;
        _endVerse = 1;
    }

    // getset
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

