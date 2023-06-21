public class Create : Base{
    string goalResp;
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

        }
    }
    public void DisplayQuestions(){
       ShowQuestions();
       Console.WriteLine("What is the amount of points associated with this goal? ");
       string pointsgoal = Console.ReadLine() ?? String.Empty;
       int _pointsgoal = Convert.ToInt32(pointsgoal);
       Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
       string accomNum = Console.ReadLine() ?? String.Empty;
       int _accomNum = Convert.ToInt32(accomNum);
       Console.WriteLine("What is the bonus for accomplishing it that many times? ");
       string bonusNum = Console.ReadLine() ?? String.Empty;
       int _bonusNum = Convert.ToInt32(bonusNum);
    }
}