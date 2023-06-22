public class Create{
    public string _goal ="";
    public string _desc="";
    public int _points;

    public Create(string goal, string desc, int points){
        _goal = goal;
        _desc = desc;
        _points = points;
    }

    public string GetGoal(){
        return _goal;
    }

}