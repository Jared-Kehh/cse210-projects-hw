public class Base{
    string goalResp;

    public void ListingGoals(){
        Console.WriteLine("The goals are:");
        foreach(string goalN in goalName){
            Console.WriteLine(goalN);
        }
        foreach(string goalD in goalDesc){
            Console.WriteLine(goalD);
        }
        foreach(int goalP in pointsGoal){
            Console.WriteLine(goalP);
        }
    }
}