public abstract class Base{
    
    int points = 0;
    List<string> goalList = new List<string>();
    public void ShowQuestions(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? String.Empty;
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine() ?? String.Empty;
        Console.Write("What is the amount of points associated with this goal? ");
        string _points = Console.ReadLine() ?? String.Empty;
        int goalpoints = Convert.ToInt32(_points);
    }

    public void DisplayQuestions(){
       ShowQuestions();
       Console.Write("How many times does this goal need to be accomplished for a bonus? ");
       string accomNum = Console.ReadLine() ?? String.Empty;
       int _accomNum = Convert.ToInt32(accomNum);
       Console.Write("What is the bonus for accomplishing it that many times? ");
       string bonusNum = Console.ReadLine() ?? String.Empty;
       int _bonusNum = Convert.ToInt32(bonusNum);
    }

    public void ShowPoints(){
        Console.WriteLine($"You have {points} points.");
    }

    public void AddingGoals(){
        
    }

}