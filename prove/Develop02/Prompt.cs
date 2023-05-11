public class Prompt{

    List<Prompt> _prompt = new List<Prompt>();
    private string _entry ="";

    public Prompt(string entry){
        _entry = entry;
    }

    public string GetJournal(){
        return _entry;
    }
    DateTime currentDateTime = DateTime.Now;
}
