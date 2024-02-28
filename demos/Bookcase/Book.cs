// ===============================
//             Book
// -------------------------------
//     - string _author
//     - string _name
//     - int _timesRead
//     - boolean _available
// -------------------------------
//     + Display
//     + IsAvailable
//     + TimesRead
//     + Checkout
//     + HasAuthor
// ===============================

public class Book
{
    private string _author;
    private string _name;
    private int _timesRead = 0;
    private bool _available = true;

    public Book(string name,string author)
    {
        _author = author;
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author} Read: {_timesRead}");
        if(!_available)
        {
            Console.WriteLine("[Checked Out]");
        }
    }

    public bool IsAvailable()
    {
        return _available;
    }
    public int TimesRead()
    {
        return _timesRead;
    }
    public void CheckOut()
    {
        _timesRead += 1;
        _available = false;
    }
    public void CheckIn()
    {
        _available = true;
    }
    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }

}