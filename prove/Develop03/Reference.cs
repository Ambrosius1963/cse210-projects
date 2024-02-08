
// ===============================
//          Reference
// -------------------------------
//     - string _book
//     - int _chapter
//     - int _verse
// -------------------------------
//     + Reference(book, chapter, verse)
// ===============================

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    // Constructor
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
}
