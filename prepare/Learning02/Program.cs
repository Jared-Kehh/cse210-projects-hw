using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineering";
        job2._jobTitle = "Manager";

        job1._company = "Microsoft";
        job2._company = "Apple";

        job1._startYear = 2019;
        job2._startYear = 2022;

        job1._endYear = 2022;
        job2._endYear = 2023;

        Resume name = new Resume();

        name._name = "Jared Keh";
        name._jobs.Add(job1);
        name._jobs.Add(job2);

        name.display();
    }
}