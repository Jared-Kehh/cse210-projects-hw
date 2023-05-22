public class Team{
    private List<Player> _players = new List<Player>();
    private string _name="";
    private int win;
    private int lose;
    public Team(string name){
        _name = name;
    }

    public void AddPlayer(Player p){
        _players.Add(p);
    }

    public void DisplayRoster(){
        Console.WriteLine($"{_name} {win}/{lose}");
        foreach (Player player in _players){
            Console.WriteLine(player.Display());
        }
    }
    public void AddWin(){
        win += 1;
    }
    public void AddLoss(){
        lose += 1;
    }
}