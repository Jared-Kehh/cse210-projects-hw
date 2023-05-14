public class Journal{

    private string _entry ="";
    private string entries="";

    public Journal(string entry, string loadentry){
        _entry = entry;
        entries = loadentry;
    }

    public string GetJournals(){
        return _entry;
    }

    DateTime currentDateTime = DateTime.Now;

}