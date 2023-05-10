public class Display{
    List<Prompt> _prompt = new List<Prompt>();
    List<Journal> _journal = new List<Journal>();

    private void PrettyPrint(string item)
    {
        Console.WriteLine("**************************");
        Console.WriteLine($"{item}");
        Console.WriteLine("**************************");
    }

    public void JournalEntries()
    {
        foreach (Journal journal in _journal)
        {
            PrettyPrint(journal.GetJournals());
        }
    }

    public void AddEntry(Prompt prompt)
    {
        _prompt.Add(prompt);
    }

    public void AddJournal(Journal journal){
        _journal.Add(journal);

    }
    
    public void GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _prompt.Count);
        PrettyPrint(_prompt[randomNumber].GetJournal());
    }

}