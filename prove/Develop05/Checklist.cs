public class ChecklistGoal : Goal
{
    private int _count = 0;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string desc, int points, int targetCount, int bonusPoints) : base(name, desc, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine($"Recorded progress on goal: {Name} (+{Points} points)");

        if (_count == _targetCount)
        {
            Points += _bonusPoints;
            Console.WriteLine($"Completed goal: {Name} ({_bonusPoints} bonus points)");
        }
    }

    public override string GetStatus()
    {
        return $"Completed {_count}/{_targetCount} times: {Name} ({Desc})";
    }
}