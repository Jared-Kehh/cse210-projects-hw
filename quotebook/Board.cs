public class Board
{
    List<Quote> _quote = new List<Quote>();

    private void NicePrint(string item)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("------------------------------");

    }

    public void ShowQuotes()
    {
        foreach (Quote quote in _quote)
        {
            NicePrint(quote.GetQuote());
        }
    }

    public void AddQuote(Quote quote)
    {
        _quote.Add(quote);
    }

    public void GetRandomQuote()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _quote.Count);
        NicePrint(_quote[randomNumber].GetQuote());
    }

    public void FindQuotesByAuthor(string author)
    {
        foreach (Quote quote in _quote)
        {
            if(quote.HasAuthor(author))
            {
                NicePrint(quote.GetQuote());
            }
        }
    }
}