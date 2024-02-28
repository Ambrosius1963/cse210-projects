// ===============================
//           Bookcase
// -------------------------------
//     - List<Book> _books
// -------------------------------
//     + ShowBooks()
//     + AddBook(book)
//     + FindBookByAuthor(author)
//     + CountBooks()
//     + ShowPopularBooks(count)
// ===============================

public class Bookcase
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine("\nShowing All Books\n-----------------------");
        foreach (Book book in _books)
        {
            book.Display();
        }
    }

    public void FindBookByAuthor(string author)
    {
        Console.WriteLine($"\nBooks by {author}\n---------------------");
        foreach (Book book in _books)
        {
            if(book.HasAuthor(author))
            {
                book.Display();
            }
        }
    }

    public void CountBooks()
    {
        Console.WriteLine($"We have {_books.Count} books");
    }

    public void ShowPopularBooks(int topN)
    {
        topN = Math.Min(topN,_books.Count);
        Console.WriteLine($"Showing the top {topN} popular books");
        int shown = 0;
        _books.Sort((x, y) => y.TimesRead().CompareTo(x.TimesRead()));
        foreach (Book book in _books)
        {
            if(shown < topN)
            {
                book.Display();
            }
            shown++;
        }


    }
}