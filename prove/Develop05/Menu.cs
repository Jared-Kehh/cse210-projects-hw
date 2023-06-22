public class Menu{
    Create newGoal = new Create();
    Record points = new Record();
    Lists listGoal = new Lists();
    public void DisplayMenu(){
        string response = "";
        string [] options = {"1","2","3","4","5","6"};
        while(response!="6"){
            while(options.Contains(response)==false){
            points.ShowPoints();
            Console.WriteLine();
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            response = Console.ReadLine() ?? String.Empty;
            response = response.ToUpper();
            }

            switch(response){
                case "1":
                newGoal.MenuTypeofGoals();
                break;

                case "2":
                listGoal.ListGoals();
                break;

                case "3":
                break;

                case "4":
                break;

                case "5":
                break;

                case "6":
                Environment.Exit(0);
                break;
            }
            response="";

        }
    }
}