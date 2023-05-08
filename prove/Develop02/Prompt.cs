public class Prompt{

    private string _entry ="";

    public Prompt(string entry){
        _entry = entry;
    }

    public string GetJournal(){
        return _entry;
    }


}