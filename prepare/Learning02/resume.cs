public class Resume{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void display(){
         Console.WriteLine($"Name: {_name}");
         Console.WriteLine($"Job:");
         foreach (Job jobs in _jobs){
            jobs.display();
        };

    }

}