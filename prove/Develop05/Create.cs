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
            DisplayQuestions();

        }
    }
}