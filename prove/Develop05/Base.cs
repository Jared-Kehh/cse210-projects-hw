public class Base{
    
    int points = 0;
    int goalpoints = 0;
    string name = "";
    string desc = "";
    string _points = "";
    public void ShowQuestions(){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? String.Empty;
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine() ?? String.Empty;
        Console.Write("What is the amount of points associated with this goal? ");
        string _points = Console.ReadLine() ?? String.Empty;
        int goalpoints = Convert.ToInt32(_points);
    }

    public void ShowPoints(){
        Console.WriteLine($"You have {points} points.");
    }


}