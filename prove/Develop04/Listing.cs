public class Listing : Base{
    int numCountDown;
    List<string> questions = new List<string>();
    List<string> answers = new List<string>();
    public void ListDisplay(){
        Name("Listing Activity");
        Welcome();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string num = Console.ReadLine();
        numCountDown = Convert.ToInt32(num);
    }

    public void AddingQuestions(){
        questions.Add("Who are people that you appreciate?");
        questions.Add("What are personal strengths of yours?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heroes?");
    }

    public void ListingActivity(){
        Random rnd = new Random();
        int randomMessage = rnd.Next(0,questions.Count);
        string promptMessage = questions[randomMessage];
        Start();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(promptMessage);
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.Clear();
    }

    public void ListAnswers(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numCountDown);

        while(DateTime.Now < endTime){
            Console.WriteLine("");
            string answer = Console.ReadLine();
            answers.Add(answer);
        }
        int numAns = answers.Count;
        Console.WriteLine($"You listed {numAns} items!");
    }

    public void Done(){
        End(numCountDown);
    }
}