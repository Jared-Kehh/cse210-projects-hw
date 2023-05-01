public class resume{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void display(){
         Console.WriteLine($"Name: {_name}");
         Console.WriteLine($"Job: {_jobs}");

    }



}