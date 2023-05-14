using System.IO;
using System.Collections.Generic;
public class Display{
    List<Prompt> _prompt = new List<Prompt>();
    List<Journal> _journal = new List<Journal>();

    public void JournalEntries()
    {
        foreach (Journal journal in _journal)
        {
            Console.WriteLine(journal.GetJournals());
            DateTime currentDateTime = DateTime.Now;
            string dateText = currentDateTime.ToShortDateString();
            Console.WriteLine(dateText);
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

    public void saveJournal(){
        DateTime currentDateTime = DateTime.Now;
        string dateText = currentDateTime.ToShortDateString();
        Console.WriteLine("What do you want to call the file?");
        string nameFile = Console.ReadLine();
        if (File.Exists(nameFile)){
            Console.WriteLine("It exists.");
            using(StreamWriter appendable = new StreamWriter("./"+nameFile, true)){
            foreach(var journal in _journal){
                appendable.WriteLine(journal.GetJournals());
                appendable.WriteLine(dateText);
            }}}
        else{
        using (StreamWriter outputFile = new StreamWriter(nameFile))
        {
           foreach (Journal journal in _journal)    
        {
            outputFile.WriteLine(journal.GetJournals());
            outputFile.WriteLine(dateText);
        }
        }}}

    public void loadJournal(){
                Console.WriteLine("What is the file name called?");
                string loadFile = Console.ReadLine();
                string fileLoad = loadFile;
                string [] lines = System.IO.File.ReadAllLines(fileLoad);
                var pieces = new List<string>();
                foreach (string line in lines)
                     {
                       if(line.Length != 0){
                             if(pieces.Count == 2){
                                var newJournal = new Journal(pieces[0], pieces[1]);
                                _journal.Add(newJournal);
                                pieces.Clear();
                             }
                             pieces.Add(line);
                        }
                     }
     }
     
     
}

