public class Reflect : Base{
    int numCountDown;
    List<string> message = new List<string>();
    List<string> questions = new List<string>();
    public void ReflectDisplay(){
        Name("Reflecting Activity");
        Welcome();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize that power you have and how you can use it in other aspects of your life.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string num = Console.ReadLine();
        numCountDown = Convert.ToInt32(num);
    }

    public void RandomMessage(){
        message.Add("Think of a time when you stood up for someone else.");
        message.Add("Think of a time when you did something really difficult.");
        message.Add("Think of a time when you helped someone in need.");
        message.Add("Think of a time when you did something truly selfless.");
    }

    public void ReflectingExercise(){
        Random rnd = new Random();
        int randomMessage = rnd.Next(0,message.Count);
        string promptMessage = message[randomMessage];
        Start();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(promptMessage);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string enterButton = Console.ReadLine() ?? String.Empty;
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.Clear();
    }

    public void RandomQuestions(){
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
    }

    public void QuestionExercise(){
        Random rnd = new Random();
        int randomQuestion = rnd.Next(0,questions.Count);
        string promptQuestion = questions[randomQuestion];
        Console.WriteLine(promptQuestion);
        Animation();
    }

    public void Exercise(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numCountDown);

        while(DateTime.Now < endTime){
            QuestionExercise();
        }
    }
    public void Done(){
        End(numCountDown);
    }

    
}