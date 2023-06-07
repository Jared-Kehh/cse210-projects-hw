public class Menu{
    Breathing _breathing = new Breathing();
    public void DisplayMenu(){

        string response= "";
        string[] options= {"1","2","3","4"};
        while(response!="4"){
            while(options.Contains(response)==false){
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
                Console.Write("Select a choice from the menu: ");
                string numChoice = Console.ReadLine() ?? String.Empty;

            }
            switch(response){
                case "4":
                Environment.Exit(0);
                break;
                
                case "1":
                _breathing.WelcomeDisplay();
                _breathing.BreathingActivity();
                break;
            }
        }


    }
}