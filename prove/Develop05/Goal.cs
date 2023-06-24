// Define the base class for all goal
public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public string Desc {get; set;}

    public Goal(string name, string desc, int points)
    {
        Name = name;
        Points = points;
        Desc = desc;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
}