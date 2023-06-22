public class Lists{

    public void ListGoals(){
        Create goals = new Create();
        List<string> nameGoal = new List<string>();
        string goalofName = goals._name;
        nameGoal.Add(goalofName);
        Console.WriteLine("The goals are:");
        foreach(string namesofGoal in nameGoal){
            Console.WriteLine(namesofGoal);
        }

    }
}