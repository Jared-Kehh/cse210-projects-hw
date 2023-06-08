public class Base{

    public string _activityName;
    public void Name(string activityName){
        _activityName = activityName;
    }

    public void CountDown(int time){
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Animation(){
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
    }

    public void Welcome(){
        Console.WriteLine($"Welcome to {_activityName}!\n");
    }

    public void End(int time){
        Console.WriteLine("Well Done!");
        Animation();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {time} seconds of the {_activityName}");
        Animation();
    }

    
}