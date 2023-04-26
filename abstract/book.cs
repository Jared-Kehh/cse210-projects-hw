public class Book
{
    private string _author;
    private string _name;
    private int _timesRad = 0;
    private bool _available = true;

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
    }

    public bool IsAvailable()
    {
        return _available;
    }
}