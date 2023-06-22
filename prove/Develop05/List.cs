public class Lists{
    List<Create> listsOfgoals = new List<Create>();
    public string _name;
    public string _desc;
    public int _goalpoints;
    public int _accomNum_;
    public int _finalbonusNum;
    string goalResp;

    public void MenuTypeofGoals(){
        Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalResp = Console.ReadLine() ?? String.Empty;

        if (goalResp == "1"){
            ShowQuestions();
            AddingGoals();
        }
        if (goalResp == "2"){
            ShowQuestions();
            AddingGoals();
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
    }

    public void AddingGoals(){
        listsOfgoals.Add(new Create(_name, _desc, _goalpoints));
    }

    public void ListGoals(){
        Console.WriteLine("The goals are:");
        foreach(Create namesofGoal in listsOfgoals){
            Console.WriteLine($"[ ]{namesofGoal._goal} ({namesofGoal._desc})");
        }

    }
}