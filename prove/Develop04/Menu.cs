public class Menu{
    Breathing _breathing = new Breathing();
    Reflect _reflecting = new Reflect();
    Listing _listing = new Listing();

    public void DisplayMenu(){

        string response= "";
        string[] options= {"1","2","3","4"};
        while(response!="4"){
            Console.Clear();
            while(options.Contains(response)==false){
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
                Console.Write("Select a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();

            }
            switch(response)
            {
                case "4":
                Environment.Exit(0);
                break;
                
                case "1":
                _breathing.BreathingDisplay();
                _breathing.BreathingExercise();
                _breathing.Done();
                break;

                case "2":
                _reflecting.ReflectDisplay();
                _reflecting.RandomMessage();
                _reflecting.ReflectingExercise();
                _reflecting.RandomQuestions();
                _reflecting.Exercise();
                _reflecting.Done();
                break;

                case "3":
                _listing.ListDisplay();
                _listing.AddingQuestions();
                _listing.ListingActivity();
                _listing.ListAnswers();
                _listing.Done();
                break;

            }
            response="";
        }


    }
}