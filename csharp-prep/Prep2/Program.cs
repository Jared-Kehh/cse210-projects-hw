using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        if (percentage < 90)
        {
            Console.WriteLine("You have an A in your grade");
        }
    }
}