public class Event{
    public string _eventTitle;
    public string _description;
    public string _address;
    public void EventTime(){
        DateTime currentDateTime = DateTime.Now;
        string dateText = currentDateTime.ToShortDateString();
        Console.WriteLine($"Time: {currentDateTime}");
    }

    public void EventQuestions(){
        Console.Write("What is the event title? ");
        string eventTitle = Console.ReadLine() ?? String.Empty;
        _eventTitle = eventTitle;
        Console.Write("What is the event about? ");
        string description = Console.ReadLine() ?? String.Empty;
        _description = description;
        Console.Write("What is the address? ");
        string address = Console.ReadLine() ?? String.Empty;
        _address = address;
    }

    public void DisplayEvent(){
        Console.WriteLine($"Event Title: {_eventTitle}\nDescription: {_description}\nAddress: {_address}");
    }
}