public class Breathing : Base{
    int numCountDown;
    
    public void BreathingDisplay(){
        Name("Breathing Activity");
        Welcome();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string num = Console.ReadLine();
        numCountDown = Convert.ToInt32(num);
    }

    public void BreathingActivity(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation();
        Console.WriteLine();
        Console.Write("Breathe In...");
        CountDown(numCountDown);
        Console.WriteLine();
        Console.Write("Breathe Out...");
        CountDown(numCountDown);

    }
    
}