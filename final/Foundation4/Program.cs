using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Bicycles bicycles = new Bicycles("Bicycle","July 19, 2023",5,5);
        bicycles.Distance();
        bicycles.Speed();
        bicycles.Pace();
        bicycles.GetSummary();
        Running runs = new Running("Running", "July 18, 2023", 9, 1);
        runs.Distance();
        runs.Speed();
        runs.Pace();
        runs.GetSummary();
        Swimming swimming = new Swimming("Swimming","July 19, 2023",1,2);
        swimming.Distance();
        swimming.Speed();
        swimming.Pace();
        swimming.GetSummary();

    }
}