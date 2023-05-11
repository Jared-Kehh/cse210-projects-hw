public class Journal{

    private string _entry ="";

    public Journal(string entry){
        _entry = entry;
    }

    public string GetJournals(){
        return _entry;
    }

    DateTime currentDateTime = DateTime.Now;
    
}