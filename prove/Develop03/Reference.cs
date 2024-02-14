
// ===============================
//          Reference
// -------------------------------
//     - string _book
//     - int _chapter
//     - int _verse
// -------------------------------
//     + Reference(book, chapter, verse)
//     + override string ToString()
// ===============================

public class Reference
{
    private string _book;//s {get; set;}
    private int _chapter;// {get; set;}
    private int _verse;// {get; set;}

    // Constructor
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public override string ToString()
    {
        if (_verse is int)
            return $"{_book} {_chapter}:{_verse}"; 
        if (_verse is string)
            return _verse;

    }
}
