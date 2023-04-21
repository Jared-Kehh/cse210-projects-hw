using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        if (percentage >= 90)
        {
            Console.WriteLine("You have an A in your grade");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("You have a B in your grade");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("You have a C in your grade");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("You have a D in your grade");
        }
        else
        {
            Console.WriteLine("You have an F in your grade");
        }

    }
}