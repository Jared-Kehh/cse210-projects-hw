using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Bicycles cycling = new Bicycles("Bicycle","July 19, 2023", 5, 5);
        cycling.Distance();
        cycling.Speed();
        cycling.Pace();
        cycling.GetSummary();
        Running runs = new Running("Running", "July 18, 2023", 10, 1);
        runs.Distance();
        runs.Speed();
        runs.Pace();
        runs.GetSummary();
        Swimming swim = new Swimming("Swimming","July 19, 2023", 3, 6);
        swim.Distance();
        swim.Speed();
        swim.Pace();
        swim.GetSummary();

    }
}