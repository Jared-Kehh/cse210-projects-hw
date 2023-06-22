public abstract class Base{
    string _name;
    string _desc;
    int _goalpoints;
    int _accomNum_;
    int _bonusNum_;
    int points = 0;
    List<string> goalName = new List<string>();
    public void ShowQuestions(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? String.Empty;
        name = _name;
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine() ?? String.Empty;
        desc = _desc;
        Console.Write("What is the amount of points associated with this goal? ");
        string _points = Console.ReadLine() ?? String.Empty;
        int goalpoints = Convert.ToInt32(_points);
        goalpoints = _goalpoints;
    }

    public void DisplayQuestions(){
       ShowQuestions();
       Console.Write("How many times does this goal need to be accomplished for a bonus? ");
       string accomNum = Console.ReadLine() ?? String.Empty;
       int _accomNum = Convert.ToInt32(accomNum);
       _accomNum = _accomNum_;
       Console.Write("What is the bonus for accomplishing it that many times? ");
       string bonusNum = Console.ReadLine() ?? String.Empty;
       int _bonusNum = Convert.ToInt32(bonusNum);
       _bonusNum = _bonusNum_;
    }

    public void ShowPoints(){
        Console.WriteLine($"You have {points} points.");
    }

    public void AddingGoals(){
        
    }

}