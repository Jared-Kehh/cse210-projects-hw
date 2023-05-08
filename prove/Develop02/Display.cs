public class Display{
    List<Prompt> _prompt = new List<Prompt>();

    private void PrettyPrint(string item)
    {
        Console.WriteLine("<==========================>");
        Console.WriteLine($"{item}");
        Console.WriteLine("<==========================>");
    }

    public void JournalEntries()
    {
        foreach (Prompt prompt in _prompt)
        {
            PrettyPrint(prompt.GetJournal());
        }
    }

    public void AddEntry(Prompt prompt)
    {
        _prompt.Add(prompt);
    }
    
    public void GetRandomEntry()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _prompt.Count);
        PrettyPrint(_prompt[randomNumber].GetJournal());
    }

}