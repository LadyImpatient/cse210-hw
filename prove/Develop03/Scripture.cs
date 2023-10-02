using System;
using System.Xml.Schema;

class Word
//Keeps track of a single word and whether it is shown or hidden.
{
    //variables
    public string _text;
    public bool _isHidden;
    
    //constructors
    public Word(string text)
    {
        this._text = text;
        _isHidden = false; 
    }

    public bool isHidden()
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
    }

public void Hide() => _isHidden = true;


}

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

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

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(0, _words.Count);

            if (randomIndex < _words.Count)
            {
                _words[randomIndex].Hide();
            }
        }
    }

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
        return _words.All(word => word._isHidden());
    }
}

class Reference
//Keeps track of the book, chapter, and verse information.
{
    //variables
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int _endVerse;
    
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
}

