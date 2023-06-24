using System;
using System.Collections.Generic;
public class EternalQuest
{
    public string goalResp;
    public string _name;
    public string _desc;
    public int _goalpoints;
    public int _accomNum_;
    public int _finalbonusNum;
    private List<Goal> _goals = new List<Goal>();

    public void DisplayMenu(){
        string response = "";
        string [] options = {"1","2","3","4","5","6"};
        while(response!="6"){
            while(options.Contains(response)==false){
            
            Console.WriteLine();
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            response = Console.ReadLine() ?? String.Empty;
            response = response.ToUpper();
            }

            switch(response){
                case "1":
                MenuTypeofGoals();
                break;

                case "2":
                DisplayStatus();
                break;

                case "3":
                goalSave();
                break;

                case "4":
                goalFind();
                break;

                case "5":
                Event();
                break;

                case "6":
                Environment.Exit(0);
                break;
            }
            response="";

        }
    }

    public void MenuTypeofGoals(){
        Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalResp = Console.ReadLine() ?? String.Empty;

        if (goalResp == "1"){
            ShowQuestions();
        }
        if (goalResp == "2"){
            ShowQuestions();
        }
        if (goalResp == "3"){
            DisplayQuestions();
        }
    }
    public void ShowQuestions(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? String.Empty;
        _name = name;
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine() ?? String.Empty;
        _desc = desc;
        Console.Write("What is the amount of points associated with this goal? ");
        string _points = Console.ReadLine() ?? String.Empty;
        int goalpoints = Convert.ToInt32(_points);
        _goalpoints = goalpoints;
        if(goalResp == "1"){
            AddGoal(new SimpleGoal(_name, _desc, _goalpoints));
        }
        if(goalResp == "2"){
            AddGoal(new EternalGoal(_name, _desc, _goalpoints));
        }
    }

    public void DisplayQuestions(){
       ShowQuestions();
       Console.Write("How many times does this goal need to be accomplished for a bonus? ");
       string accomNum = Console.ReadLine() ?? String.Empty;
       int _accomNum = Convert.ToInt32(accomNum);
       _accomNum_ = _accomNum;
       Console.Write("What is the bonus for accomplishing it that many times? ");
       string bonusNum = Console.ReadLine() ?? String.Empty;
       int _bonusNum = Convert.ToInt32(bonusNum);
       _finalbonusNum = _bonusNum;
       AddGoal(new ChecklistGoal(_name, _desc, _goalpoints, _accomNum_, _finalbonusNum));
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Added goal: {goal.Name}");
    }

    public void Event(){
        DisplayStatus();
        Console.Write("What goal did you accomplish? ");
        string goalAccomp = Console.ReadLine() ?? String.Empty;
        RecordEvent(goalAccomp);

    }

    public void RecordEvent(string name)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.Name == name)
            {
                goal.RecordEvent();
                return;
            }
        }

        Console.WriteLine($"Goal not found: {name}");
    }

    public void DisplayStatus()
    {
        int totalPoints = 0;

        Console.WriteLine("Current Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStatus());
            totalPoints += goal.Points;
        }

        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void goalSave(){
        string FileName = "";
        Console.WriteLine("What is the filename for the goal file? ");
        FileName = Console.ReadLine() ?? String.Empty;
        using (StreamWriter outputFile = new StreamWriter(FileName)){
            foreach(Goal c in _goals){
                outputFile.WriteLine($"{c.Name},{c.Desc},{c.Points}");
            }
        }
    }

    public void goalFind(){
        Console.WriteLine("What is the filename for the goal file? ");
        string findGoal = Console.ReadLine() ?? String.Empty;
        string FileName = findGoal;
        string [] lines = System.IO.File.ReadAllLines(FileName);
        var pieces = new List<string>();
        foreach (string line in lines){
            string[] parts = line.Split(",");
            var newGoal = new SimpleGoal(parts[0], parts[1], Convert.ToInt32(parts[2]));
            _goals.Add(newGoal);
        }
    }
}