public class Event{
    public string _typeEvent;
    public string _description;
    public string _title;
    private string _date;
    private string _time;
    public Event(string typeEvent, string title, string desc, string date, string time)
    {
        _typeEvent = typeEvent;
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
    }

    public void Type()
    {
        Console.WriteLine($"{_typeEvent} Event.\n");
    }

    public void shortDesc()
    {
        Console.WriteLine($"{_typeEvent} Event\nEvent Title: {_title}\nDate: {_date}");
    }

    public void standardDesc()
    {
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}");
    }
}