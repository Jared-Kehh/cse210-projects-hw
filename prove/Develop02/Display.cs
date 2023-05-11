public class Display{
    List<Prompt> _prompt = new List<Prompt>();
    List<Journal> _journal = new List<Journal>();

    public void JournalEntries()
    {
        foreach (Journal journal in _journal)
        {
            Console.WriteLine(journal.GetJournals());
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
        }
    }

    public void AddEntry(Prompt prompt)
    {
        _prompt.Add(prompt);
    }

    public void AddJournal(Journal journal){
        _journal.Add(journal);
    }
    
    public void GetRandomEntry()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _prompt.Count);
        Console.WriteLine(_prompt[randomNumber].GetJournal());
    }

}