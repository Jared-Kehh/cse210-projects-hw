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

    public void TypeofEvent()
    {
        Console.WriteLine($"{_typeEvent} Event.\n");
    }

    public void ShortDesc()
    {
        Console.WriteLine($"{_typeEvent} Event\nEvent Title: {_title}\nDate: {_date}");
    }

    public void StandardDesc()
    {
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}");
    }
}