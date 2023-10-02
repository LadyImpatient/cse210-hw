using System;
class Scripture
{
    private Reference _reference;
    private string[] _words;
    private int _currentWordIndex;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = scriptureText.Split(' ');
        _currentWordIndex = 0;
    }

    public bool HideNextWord()
    {
        if (_currentWordIndex < _words.Length)
        {
            _words[_currentWordIndex] = new string('_', _words[_currentWordIndex].Length);
            _currentWordIndex++;
            return true;
        }
        return false;
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (string word in _words)
        {
            displayText += word + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (string word in _words)
        {
            if (!word.Contains('_'))
            {
                return false;
            }
        }
        return true;
    }
}

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

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
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

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
