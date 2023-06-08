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
        Console.WriteLine();
        Console.Write("Breathe In...");
        CountDown(4);
        Console.WriteLine();
        Console.Write("NOW Breathe Out...");
        CountDown(6);
        Console.WriteLine();
    }

    public void BreathingExercise(){
        Start();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numCountDown);

        while(DateTime.Now < endTime){
            BreathingActivity();
        }
    }

    public void Done(){
        End(numCountDown);
    }
    
}