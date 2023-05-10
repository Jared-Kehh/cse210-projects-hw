public class Menu{
    private Display _display;

    public Menu(Display display)
    {
        _display = display;
    }

    public void DisplayMenu()
    {
        string response = "";
        string[] options = {"1", "2", "5", "3"};
        while(response!="5")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\n\nWhat is your request? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch(response)
            {
                case "5":
                    Environment.Exit(0);
                    break;
                case "1":
                    _display.GetRandomPrompt();
                    Console.Write("");
                    string journalEntry = Console.ReadLine();
                    _display.AddJournal(new Journal(journalEntry));
                    break;
                
                case "2":
                    _display.JournalEntries();
                    break;
                case "3":
                    _display.GetRandomPrompt();
                    break;
            }
            response="";
        }
    }
}