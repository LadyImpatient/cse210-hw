using System;

class Scripture
//Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
{
    //variables 
    private Reference _reference;
    public List<Word> _words = new List<Word>;

    //constructors
}

class Word
//Keeps track of a single word and whether it is shown or hidden.
{
    //variables
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;
    
    //constructors

}

class Reference
//Keeps track of the book, chapter, and verse information.
{
    //variables
    public string _text;
    public bool _isHidden;
    
    //constructors

}

