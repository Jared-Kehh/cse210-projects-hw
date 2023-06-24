using System;
using System.Collections.Generic;
// Define the derived classes for each type of goal
public class SimpleGoal : Goal
{
    private string ex = "";
    private int _count = 0;
    public SimpleGoal(string name, string desc, int points) : base(name, desc, points) {}

    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine($"Completed goal: {Name} (+{Points} points)");
        if(_count == 1){
            ex = "X";
        }
    }

    public override string GetStatus()
    {
        return $"[{ex}] {Name} ({Desc})";
    }
}