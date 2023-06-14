public class Create : Base{
    string goalResp;
    public void MenuTypeofGoals(){
        Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalResp = Console.ReadLine() ?? String.Empty;

        if (goalResp == "1"){
            DisplayQuestions();
        }
    }
    public void DisplayQuestions(){
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine() ?? String.Empty;
        Console.Write("What is a short description of it? ");
        string shortdes = Console.ReadLine() ?? String.Empty;
    }
}