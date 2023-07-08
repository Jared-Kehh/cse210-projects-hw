public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string weather, string typeEvent, string title, string desc, string date, string time) : base(typeEvent, title, desc, date, time)
    {
        _weather = weather;
    }

    public void OutDesc()
    {
        Console.WriteLine($"The weather today will be {_weather}");
    }
}