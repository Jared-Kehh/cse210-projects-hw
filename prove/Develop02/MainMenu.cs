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
                Console.Write("1. Write\n2. Display\n3. Random Entry\n4. Load\n5. Quit\n\nWhat is your request? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch(response)
            {
                case "5":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.Write("Please Enter New Journal Entry: ");
                    string newEntry = Console.ReadLine() ?? String.Empty;

                    _display.AddEntry(new Prompt(newEntry));
                    break;
                
                case "2":
                    _display.JournalEntries();
                    break;
                case "3":
                    _display.GetRandomEntry();
                    break;
            }
            response="";
        }
    }
}