public class Lectures : Event
{
    private string _name;
    private int _capacity;

    public Lectures(string name, int capacity, string typeEvent, string title, string desc, string date, string time) : base(typeEvent, title, desc, date, time)
    {
        _name = name;
        _capacity = capacity;
    }

    public void LecDesc()
    {
        Console.WriteLine($"Speaker: {_name}, capacity: {_capacity}");
    }
}