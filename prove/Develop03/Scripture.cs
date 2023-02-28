public class Scripture
{
    private string _book;
    private int _chapter;
    private string _verseStart;
    private string _verseEnd;




    public Scripture(string book, int chapter, string verse)
    {
        _book= book;
        _chapter= chapter;
        _verseStart= verse;
    }

    public Scripture(string book, int chapter, string verseStart, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    static bool ValidVerse()
    {
        return true;
    }

    static bool ValidRange()
    {
        return true;
    }

    static bool ValidBook()
    {
        return true;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public string GetVerse()
    { 
        return _verseStart + _verseEnd; 
    }


}