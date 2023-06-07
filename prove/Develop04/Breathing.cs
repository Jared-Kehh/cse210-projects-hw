public class Breathing{
    int numCountDown;
    public void WelcomeDisplay(){
        Console.WriteLine("Welcome to Breathing Activity!\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
    }
    public void CountDown(){
        // Console.WriteLine("How long, in seconds, would you like for your session? ");
        // string num = Console.ReadLine();
        // numCountDown = Convert.ToInt32(num);
        Console.WriteLine("Get Ready...\n");
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Breathe In...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void BreathingActivity(){
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string num = Console.ReadLine();
        numCountDown = Convert.ToInt32(num);
    }
    
}